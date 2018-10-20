using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Lv4 : MonoBehaviour {
    public ClockControl clock;
    public Sprite doorOpen;
    public Sprite doorClosed;
    SpriteRenderer renderDoor;

    void Start()
    {
        renderDoor = gameObject.GetComponent<SpriteRenderer>();
        renderDoor.sprite = doorClosed;
    }

    void Update()
    {
        if (clock.doorUnlock)
        {
            renderDoor.sprite = doorOpen;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (clock.doorUnlock)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
