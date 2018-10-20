using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Lv3 : MonoBehaviour {
    public ChandelierControl chandelier;
    public Sprite doorOpen;
    public Sprite doorClosed;
    SpriteRenderer renderDoor;
	// Use this for initialization
	void Start () {
        renderDoor = gameObject.GetComponent<SpriteRenderer>();
        renderDoor.sprite = doorClosed;
	}
	
	// Update is called once per frame
	void Update () {
		if (chandelier.doorUnlock)
        {
            renderDoor.sprite = doorOpen;
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (chandelier.doorUnlock)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
