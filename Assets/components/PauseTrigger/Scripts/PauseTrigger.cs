using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseTrigger : MonoBehaviour {

    public GameObject player;
    public GameObject canvas;
    public NarratorTrigger narratorTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            StartCoroutine(PauseCoroutine());
        }
    }

    IEnumerator PauseCoroutine()
    {
        GamePause gamePause = canvas.GetComponent<GamePause>();
        gamePause.Pause();
        narratorTrigger.Play();
        Debug.Log(narratorTrigger.GetLength());
        yield return new WaitForSecondsRealtime(narratorTrigger.GetLength());
        gamePause.Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
