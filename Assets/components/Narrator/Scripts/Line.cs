using UnityEngine;

public class Line
{
    private AudioSource _audio;
    private string _line;

    public Line(string line)
    {
        _line = line;
    }

    public void registerAudio(AudioSource audio)
    {
        _audio = audio;
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
