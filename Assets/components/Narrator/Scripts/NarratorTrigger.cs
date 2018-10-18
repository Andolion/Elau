using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NarratorTrigger : MonoBehaviour
{

    public string line;
    private Line _line;

    // Use this for initialization
    void Start()
    {
        _line = new Line(line);
        StartCoroutine(downloadTextToSpeech(_line));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator downloadTextToSpeech(Line line)
    {
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(this._getUrl(line.getString()), AudioType.MPEG))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError)
            {
                Debug.Log(www.error);
            }
            else
            {
                line.registerAudio(DownloadHandlerAudioClip.GetContent(www));
            }
        }
    }

    private string _getUrl(string text)
    {
        return "http://translate.google.com/translate_tts?tl=en&q=" + UnityWebRequest.EscapeURL(text) + "&client=tw-ob.mpeg";
    }
}
