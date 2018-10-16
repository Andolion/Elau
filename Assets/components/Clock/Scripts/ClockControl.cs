using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockControl : MonoBehaviour
{

    public Sprite clock3;
    public Sprite clock6;
    private SpriteRenderer spriteClock;

    // Use this for initialization
    void Start()
    {
        spriteClock = GetComponent<SpriteRenderer>();
        if (spriteClock.sprite == null)
            spriteClock.sprite = clock3;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) // TODO change on collision with platform on clock
        {
            changeClock(); // call method to change sprite
        }
    }

    void changeClock()
    {
        if (spriteClock.sprite == clock3) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteClock.sprite = clock6;
        }
        else
        {
            spriteClock.sprite = clock3; // otherwise change it back to sprite1
        }
    }
}