using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlControlScr : StartLvl
{
    
    
    //public void LoadLvl()
    //{
        
    //    level = PlayerPrefs.GetInt("Level", level);
    //    //if(level == 0)
    //    //{
    //    //    LoadFirstLevel();
    //    //}
    //    //else
    //    //{
    //        LoadLevel();
    //    //}
    //}

    public void LoadFirstLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(1);
    }
    public void LoadLevel()
    {
        level = PlayerPrefs.GetInt("Level", level);
        SceneManager.LoadScene(level);
    }
}
