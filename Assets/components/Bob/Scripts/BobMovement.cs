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
    public NarratorTrigger clip1Lv3;
    public NarratorTrigger clip2Lv3;
    int triggerLv3 = 2;

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
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                dir = -1;
                if (triggerLv5 == 1)
                {
                    clipLv5.Play();
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

        if (level == 3 && Input.GetKeyDown(KeyCode.Space) && triggerLv3 == 2)
        {
            clip1Lv3.Play();
            triggerLv3--;
        }

        if (Input.GetButtonDown("Jump") && jumpEnabled)
        {
            jump = true;
            
            if(level == 3 && triggerLv3 == 1)
            {
                clip2Lv3.Play();
                triggerLv3--;
            }
        }
    }

    void FixedUpdate() {

        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
