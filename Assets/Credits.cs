using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        }
    }

    IEnumerator ThisIsTheEnd()
    {
        end.Play();
        yield return new WaitForSeconds(end.GetLength());
        SceneManager.LoadScene("Menu");
    }
}
