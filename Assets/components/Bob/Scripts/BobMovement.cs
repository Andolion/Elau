using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BobMovement : MonoBehaviour {

    public BobCharacterControl control;
    float horizontalMove = 0;
    public float runSpeed = 40;
    bool jumpEnabled = true;
    private bool jump = false;
    int level;

    //used for level 5 only
    public NarratorTrigger clipLv5;
    int dir;
    int triggerLv5 = 1;

    //used for level 3 only
    public NarratorTrigger clipLv3;
    int triggerLv3 = 1;

    private void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex - 1;
        if (level == 1 || level == 2)
        {
            jumpEnabled = false;
        }
    }
    // Update is called once per frame
    void Update () {

        if (level == 5)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                dir = 1;
                if (triggerLv5 == 1)
                {
                    clipLv5.Play();
                    triggerLv5--;
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                dir = -1;
                if (triggerLv5 == 1)
                {
                    clipLv5.Play();
                    triggerLv5--;
                }
            }
            else
            {
                dir = 0;
            }
            horizontalMove = dir * runSpeed;
        }
        else
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        }

        if (level == 3 && Input.GetKeyDown(KeyCode.Space) && triggerLv3 == 1)
        {
            clipLv3.Play();
            triggerLv3--;
        }

        if (Input.GetButtonDown("Jump") && jumpEnabled)
        {
            jump = true;
        }
    }

    void FixedUpdate() {

        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
