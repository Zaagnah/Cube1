
using System.Runtime.InteropServices;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forwardForce = 2000f;
    public float sidewaysForce = 70f;
    public Joystick joystick;
    public GameObject _joystick;
    bool mobile;

    
   private void Awake()
   {
        if(Application.isMobilePlatform)
        {
            mobile = true;

        }else mobile = false;
        Debug.Log(mobile);
   }



         private   void FixedUpdate()
    {

        //Debug.Log(currentPlatform);
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        

        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        MoveMove();

    }

    public void MoveMove()
    {
        if(mobile)
        {
        
            _joystick.SetActive(true);    
            float horizontalInput = joystick.Horizontal;
            transform.Translate(new Vector3(horizontalInput, 0, 0) * sidewaysForce * Time.deltaTime);
            //panelL.SetActive(true);
        }else {
            
        //    float verticalInput = Input.GetAxis("Vertical");

        
            float horizontalInput = Input.GetAxis("Horizontal"); //клавиши
            //Debug.Log(currentPlatform + " klava");
            transform.Translate(new Vector3(horizontalInput, 0, 0) * sidewaysForce * Time.deltaTime);
          }
            
        
        
    }



}
