using UnityEngine;

public class Line
{
    private AudioSource _audio = new AudioSource();
    private string _line;

    public Line(string line)
    {
        _line = line;
    }

    public void registerAudio(AudioClip audio)
    {
        _audio.clip = audio;
        this.play();
    }

    public void play()
    {
        _audio.Play();
    }

    public string getString()
    {
        return _line;
    }
}
