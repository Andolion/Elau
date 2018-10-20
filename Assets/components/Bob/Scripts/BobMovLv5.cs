using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobMovLv5 : MonoBehaviour {

    public BobCharacterControl control;
    float horizontalMove = 0;
    public float runSpeed = 40;
    bool jump = false;
    int dir = 0;

	void Update () {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dir = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = -1;
        }
        else
        {
            dir = 0;
        }
        horizontalMove = dir * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
	}

    void FixedUpdate() {

        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
