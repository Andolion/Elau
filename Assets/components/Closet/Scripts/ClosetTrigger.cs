using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetTrigger : MonoBehaviour
{

    public GameObject player;
    public Collider2D closet;
    public Sprite closetClosed;
    public Sprite closetOpen;
    public new SpriteRenderer renderer;
    public bool collision; 

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.gameObject == player)
        {
            renderer.sprite = closetOpen;
        }
    }

    void OnTriggerExit2D(Collider2D collisionInfo)
    {
        if (collisionInfo.gameObject == player)
        {
            renderer.sprite = closetClosed;
        }
    }
}
