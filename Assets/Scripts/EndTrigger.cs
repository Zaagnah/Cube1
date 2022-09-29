using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement playerMovement;
   
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
        playerMovement.forwardForce = 0f;
        playerMovement.sidewaysForce = 0f;
                
    }

}
