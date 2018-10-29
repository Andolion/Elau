using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NarratorTrigger : MonoBehaviour
{

    public GameObject player;
    public AudioClip audioClip;
    private Line _line;
    private bool hasPlayed = false;

    // Use this for initialization
    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        _line = new Line(audioSource);
    }

    // Update is called once per frame
    void Update() { }

    public float GetLength()
    {
        return _line.GetLength();
    }

    public void Play()
    {
        _line.Play();
        hasPlayed = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player && !hasPlayed)
        {
            this.Play();
        }
    }

    /*
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

    */
}
