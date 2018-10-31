using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockControl : MonoBehaviour
{
    public GameObject player;
    public Sprite clock3;
    public Sprite clock6;
    private SpriteRenderer spriteClock;
    public Door_Default door;
    public NarratorTrigger narrator;

    // Use this for initialization
    void Start()
    {
        spriteClock = GetComponent<SpriteRenderer>();
        if (spriteClock.sprite == null)
            spriteClock.sprite = clock3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (door.level == 4)
        {
            StartCoroutine(clockingAlong());
        }
    }

    IEnumerator clockingAlong()
    {
        changeClock(); // call method to change sprite
        narrator.Play();
        yield return new WaitForSeconds(narrator.GetLength());
        door.doorUnlock = true;
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