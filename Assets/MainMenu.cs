using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ContiueGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("level", 0);
        PlayerPrefs.Save();
        print(PlayerPrefs.GetInt("level"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
