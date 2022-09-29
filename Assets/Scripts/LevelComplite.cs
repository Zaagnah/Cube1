//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class LevelComplite : MonoBehaviour
//{
//    public int level = 0;

   
//    public void LoadNextLevel()
//    {
//        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


//        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//        int nextSceneIndex = currentSceneIndex + 1;
//        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
//        {
//            nextSceneIndex = 0; 
//        }
//        SceneManager.LoadScene(nextSceneIndex);
//        Debug.Log("loaded");
//        PlayerPrefs.SetInt("Level", nextSceneIndex);
//        PlayerPrefs.Save();
//        Debug.Log("saved");
//        level = nextSceneIndex;


//    }


//}
