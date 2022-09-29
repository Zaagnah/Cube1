using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forwardForce = 2000f;
    public float sidewaysForce = 70f;
    public Joystick joystick;
   

  
    void FixedUpdate()
    {
        
        
            rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

            //MoveRight();
            //MoveLeft();

            //if (Input.GetKey("d"))
            //{
            //    rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //}
            //if (Input.GetKey("a"))
            //{
            //    rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //}

            if (rigidbody.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            MoveMove();
        
    }
    public void MoveMove()
    {
        ////float horizontalInput = Input.GetAxis("Horizontal"); //клавиши
        //    float verticalInput = Input.GetAxis("Vertical");

        float horizontalInput = joystick.Horizontal;
        transform.Translate(new Vector3(horizontalInput, 0, 0) * sidewaysForce * Time.deltaTime);
    }

   
    
   
}
