using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChandelierControl : MonoBehaviour
{
    public Door_Default door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (door.level == 3)
        {
            door.doorUnlock = true;
        }
    } 
}
