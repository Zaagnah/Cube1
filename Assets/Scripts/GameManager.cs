using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using System.Threading;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   
    bool gameHasEnded = false;
   
    public GameObject completeLevelUI;
    public int scoreLvl = 0;
    public GameObject joystick;
    ////public string placementId = "Banner";
   
    


    private void Start()
    {

        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4091912", false);
        }
        scoreLvl = PlayerPrefs.GetInt("ScoreLvl", scoreLvl);
            Debug.Log(scoreLvl);
            
            
            
            //StartCoroutine(ShowBannerThenInitialized());
        
        
    }

    //IEnumerator ShowBannerThenInitialized()
    //{
    //    while (!Advertisement.isInitialized)
    //    {
    //        yield return new WaitForSeconds(0.5f);
    //    }
    //    Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    //    Advertisement.Banner.Show(placementId);
    //}

    public void CompleteLevel()
    {
        
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //int nextSceneIndex = currentSceneIndex + 1;
        //if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        //{
        //    nextSceneIndex = 0; // loop back to start
        //}
        //SceneManager.LoadScene(nextSceneIndex);
        //Debug.Log("loaded");
        //PlayerPrefs.SetInt("Level", nextSceneIndex);
        //PlayerPrefs.Save();
        //Debug.Log("saved");
        //level = nextSceneIndex;
        scoreLvl++;
        PlayerPrefs.SetInt("ScoreLvl", scoreLvl);
        PlayerPrefs.Save();
        if (scoreLvl == 1)
        {
            Reklama();
        }
        completeLevelUI.SetActive(true);
        joystick.SetActive(false);


        

    }



    public void Reklama()
    {
        Advertisement.IsReady("video");
        {
            Advertisement.Show();
            scoreLvl = 0;
            PlayerPrefs.SetInt("ScoreLvl", scoreLvl);
            PlayerPrefs.Save();
        }
    }


    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart",2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    


}
