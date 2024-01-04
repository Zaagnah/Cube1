using UnityEngine;

public class SoundScr : MonoBehaviour
{
    [SerializeField]
    private AudioSource audio;
    private static SoundScr instance = null;
    void Awake()
    {
        audio.Play();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
    }
}

