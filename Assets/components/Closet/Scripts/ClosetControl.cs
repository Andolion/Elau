using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetControl : MonoBehaviour {

    public Sprite closetClosed;
    public Sprite closetOpen;
    private SpriteRenderer spriteCloset;
    public bool doorUnlock = false;
    public GameObject player;
    bool col = false;

    // Use this for initialization
    void Start() {
        spriteCloset = GetComponent<SpriteRenderer>();
        if (spriteCloset.sprite == null)
            spriteCloset.sprite = closetClosed;
    }

    private void Update()
    {
        if (player.transform.position.x <= -3 && player.transform.position.x >= -5 && player.transform.position.y <= 2.5 && player.transform.position.y >= 0)
        {
            col = true;
        }
        else
        {
            col = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && col)
        {
            OpenCloset(); // call method to change sprite
            doorUnlock = true;
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
