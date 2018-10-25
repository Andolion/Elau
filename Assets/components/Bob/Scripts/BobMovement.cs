using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobMovement : MonoBehaviour {

    public BobCharacterControl control;
    float horizontalMove = 0;
    public float runSpeed = 40;
    public bool jumpEnabled = true;
    private bool jump = false;

	// Update is called once per frame
	void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
	}

    void FixedUpdate() {

        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
