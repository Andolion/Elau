using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobMov_lvl2 : MonoBehaviour
{

    public BobCharacterControl control;
    float horizontalMove = 0;
    public float runSpeed = 40;
    public bool jumpEnabled = true;
    private bool jump = false;

    // Use this for initialization
    void Start()
    {

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
