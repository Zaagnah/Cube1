
//using UnityEngine;

//public class SoundScr : MonoBehaviour
//{
//    void Awake()
//    {
//        DontDestroyOnLoad(transform.gameObject);
//    }
//}

using UnityEngine;

public class SoundScr : MonoBehaviour
{
    private static SoundScr instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
    }
}
