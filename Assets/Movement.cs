using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public CharacterController2D control;
    public Animator animator;
    float horizontalMove = 0;
    public float runSpeed = 40;
    bool jump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
	}

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate() {

        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
