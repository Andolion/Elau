using UnityEngine;

public class Line
{
    private AudioSource _audio;

    public Line(AudioSource audio)
    {
        _audio = audio;
    }
    

    public void Play()
    {
        _audio.Play();
    }
    
    public float GetLength()
    {
        return _audio.clip.length;
    }
}
