using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobMovLv3 : MonoBehaviour
{

    public BobCharacterControl control;
    float horizontalMove = 0;
    public float runSpeed = 40;
    public bool jumpEnabled = false;
    private bool jump = false;

    void Start()
    {
        jumpEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
     

        if (Input.GetKeyDown(KeyCode.J) && jumpEnabled)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {

        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
