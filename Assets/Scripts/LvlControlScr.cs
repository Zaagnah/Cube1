using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlControlScr : Adv
{
    
    public GameObject buttonLoad;
    

    public void LoadFirstLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(1);
    }
    public void LoadLevel()
    {
        level = Social.PlayerPrefs.GetInt("Level", level);
        SceneManager.LoadScene(level);
       if(level > 0)
        {
            SceneManager.LoadScene(level);
        }
        else if (level < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    
}
