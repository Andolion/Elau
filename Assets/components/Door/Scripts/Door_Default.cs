using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Default : MonoBehaviour {

    //The two door sprites and the rendered
    public Sprite doorOpen;
    public Sprite doorClosed;
    SpriteRenderer renderDoor;

    //The current level of the game
    public int level;
    public bool doorUnlock;

    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex - 1;
        renderDoor = gameObject.GetComponent<SpriteRenderer>();


        if (level == 1 || level == 2 || level ==5)
        {
            renderDoor.sprite = doorOpen;
            doorUnlock = true;
        }
        else
        {
            renderDoor.sprite = doorClosed;
            doorUnlock = false;
        }       
    }

    void Update()
    {
        if (doorUnlock)
        {
            renderDoor.sprite = doorOpen;
        }
        else
        {
            renderDoor.sprite = doorClosed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (doorUnlock)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
