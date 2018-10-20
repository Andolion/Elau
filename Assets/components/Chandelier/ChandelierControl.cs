using UnityEngine;
using System.Collections;

  
    public class ChandelierControl : MonoBehaviour
    {
    public bool doorUnlock = false;
    public bool onChandelier = false;

    void Start()
        {
           
        }

    private void OnTriggerEnter2D(Collider2D other)
    {
        onChandelier = true;
    }
   
    void Update()
        {
             if(onChandelier)
            {
                doorUnlock = true;
            }
        }
        

    }
