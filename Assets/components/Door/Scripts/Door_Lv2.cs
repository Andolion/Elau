using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Lv2 : MonoBehaviour {
    public StairsTrap stairs;
    public Sprite doorOpen;
    public Sprite doorClosed;
    SpriteRenderer renderDoor;

    void Start()
    {
        renderDoor = gameObject.GetComponent<SpriteRenderer>();
        renderDoor.sprite = doorOpen;
    }

    void Update()
    {
        if (stairs.doorUnlock == false)
        {
            renderDoor.sprite = doorClosed;
        }
    }
}
