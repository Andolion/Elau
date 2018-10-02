using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {
	
	// Update is called once per frame
    void OnTriggerEnter2D (Collider2D collision) {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
