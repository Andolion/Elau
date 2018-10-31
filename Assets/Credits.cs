using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {
    public NarratorTrigger end;
    int trigger = 1;

    // Use this for initialization
    private void Update()
    {
        if(trigger == 1)
        {
            StartCoroutine(ThisIsTheEnd());
            trigger--;
            Application.Quit();
        }
    }

    IEnumerator ThisIsTheEnd()
    {
        end.Play();
        yield return new WaitForSeconds(end.GetLength());
    }
}
