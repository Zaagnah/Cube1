using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
   
    bool gameHasEnded = false;
   
    public GameObject completeLevelUI;
    //public int scoreLvl = 0;
    public GameObject joystick;
    public GameObject menuButt;
    //[SerializeField]
    //private GameObject soundMenu;
    //AudioSource source;
    [SerializeField]
    private AudioListener audio;

      [DllImport("__Internal")]
    private static extern void ShowAdv();
       
   


    public void Start()
    {
        //scoreLvl = PlayerPrefs.GetInt("ScoreLvl", scoreLvl);
            //Debug.Log(scoreLvl);
        
        //var musishn = FindObjectOfType<AudioSource>();
       // source = musishn;
       // source.Play();
            
    }


    public void CompleteLevel()
    {
        
       
        //scoreLvl++;
        //PlayerPrefs.SetInt("ScoreLvl", scoreLvl);
        //PlayerPrefs.Save();
        //if (scoreLvl == 4)
        //{

            menuButt.SetActive(false);
            //source.Stop();
            completeLevelUI.SetActive(true);
            joystick.SetActive(false);
            Reklama();
       // }
        


        

    }



    public void Reklama()
    {
            ShowAdv();
            //GameDistribution.Instance.ShowAd();
            //scoreLvl = 0;
           // PlayerPrefs.SetInt("ScoreLvl", scoreLvl);
            //PlayerPrefs.Save();
        
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

    public void SoundOn()
    {
        Debug.Log("adv");
        AudioListener.volume = 1f;

    }

    public void SoundOff()
    {
        AudioListener.volume = 0f;
    }
    


}
