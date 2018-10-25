using UnityEngine;
using System.Collections;

  
    public class ChandelierControl : MonoBehaviour
    {
    public bool doorUnlock = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        doorUnlock = true;
    }
    }
