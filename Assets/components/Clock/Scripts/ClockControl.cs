using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockControl : MonoBehaviour
{
    public GameObject player;
    public Sprite clock3;
    public Sprite clock6;
    private SpriteRenderer spriteClock;
    public bool doorUnlock;

    // Use this for initialization
    void Start()
    {
        doorUnlock = false;
        spriteClock = GetComponent<SpriteRenderer>();
        if (spriteClock.sprite == null)
            spriteClock.sprite = clock3;
    }

    void OnTriggerEnter2D(Collider2D collision) // TODO change on collision with platform on clock
    {
        if(collision.gameObject == player)
        {
            StartCoroutine(clockingAlong());
        }

    }
    
    IEnumerator clockingAlong()
    {
        changeClock(); // call method to change sprite
        yield return new WaitForSeconds(5);
        doorUnlock = true;
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