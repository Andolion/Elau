using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairsTrap : MonoBehaviour {
    public Door_Default door;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door.level == 2)
        {
            door.doorUnlock = false;
        }
    }
}
