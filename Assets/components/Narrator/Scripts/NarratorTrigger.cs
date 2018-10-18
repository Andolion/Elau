using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NarratorTrigger : MonoBehaviour
{

    public GameObject player;
    public string line;
    private Line _line;
    private bool hasPlayed = false;

    // Use this for initialization
    void Start()
    {
        _line = new Line(line);
        StartCoroutine(DownloadTextToSpeech(_line));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player && !hasPlayed)
        {
            Debug.Log("PLAYING");
            _line.play();
            hasPlayed = true;
        }
    }

    IEnumerator DownloadTextToSpeech(Line line)
    {
        string url = this._getUrl(line.getString());

        using (UnityWebRequest source = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.OGGVORBIS))
        {
            yield return source.SendWebRequest();

            if (source.isNetworkError || source.isHttpError)
            {
                Debug.LogError(source.error);
                yield break;
            }

            AudioClip clip = DownloadHandlerAudioClip.GetContent(source);
            AudioSource tempAudio = gameObject.AddComponent<AudioSource>();
            tempAudio.clip = clip;
            line.registerAudio(tempAudio);
        }
    }

    private string _getUrl(string text)
    {
        return "http://api.voicerss.org/?key=d37faacd338249fb903865d830cdb09e&hl=en-us&c=OGG&src=" + UnityWebRequest.EscapeURL(text);
    }
}
