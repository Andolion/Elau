using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveGame : MonoBehaviour {

    public void Awake()
    {
        if (PlayerPrefs.GetInt("level") < SceneManager.GetActiveScene().buildIndex)
        {
            PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.Save();
            print(PlayerPrefs.GetInt("level"));
        }
    }
}
