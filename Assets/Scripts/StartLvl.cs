using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLvl : MonoBehaviour
{
    //    public GameObject button;

      public int level = 0;
    public void NewLvlButt()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0; // loop back to start
        }
        SceneManager.LoadScene(nextSceneIndex);
        Debug.Log("loaded");
        PlayerPrefs.SetInt("Level", nextSceneIndex);
        PlayerPrefs.Save();
        Debug.Log("saved");
        level = nextSceneIndex;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            NewLvlButt();
        }
    }
}
