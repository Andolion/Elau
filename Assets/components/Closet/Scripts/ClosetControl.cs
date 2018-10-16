using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetControl : MonoBehaviour {

    public Sprite closetClosed;
    public Sprite closetOpen;
    private SpriteRenderer spriteCloset;

    // Use this for initialization
    void Start() {
        spriteCloset = GetComponent<SpriteRenderer>();
        if (spriteCloset.sprite == null)
            spriteCloset.sprite = closetClosed;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) // If the space bar is pushed down + location of character TODO
        {
            OpenCloset(); // call method to change sprite
        }
    }

    void OpenCloset()
    {
        if (spriteCloset.sprite == closetClosed) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteCloset.sprite = closetOpen;
        }
        else
        {
            spriteCloset.sprite = closetClosed; // otherwise change it back to sprite1
        }
    }
}
