using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsTrap : MonoBehaviour {
    public bool doorUnlock = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        doorUnlock = false;
    }
}
