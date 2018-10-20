 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour {

    public void PlayLevel1()
    {
        if (PlayerPrefs.GetInt("level") >= 2)
        {
            SceneManager.LoadScene("Level1");
        }
    }

    public void PlayLevel2()
    {
        if (PlayerPrefs.GetInt("level") >= 3)
        {
            SceneManager.LoadScene("Level2");
        }
    }

    public void PlayLevel3()
    {
        if (PlayerPrefs.GetInt("level") >= 4)
        {
            SceneManager.LoadScene("Level3");
        }
    }

    public void PlayLevel4()
    {
        if (PlayerPrefs.GetInt("level") >= 5)
        {
            SceneManager.LoadScene("Level4");
        }
    }

    public void PlayLevel5()
    {
        if (PlayerPrefs.GetInt("level") >= 6)
        {
            SceneManager.LoadScene("Level5");
        } 
    }

    public void PlayLevel6()
    {
        if (PlayerPrefs.GetInt("level") >= 7)
        {
            SceneManager.LoadScene("Level6");
        }   
    }
}
