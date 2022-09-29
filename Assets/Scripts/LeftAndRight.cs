using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAndRight : MonoBehaviour
{

    public Rigidbody rigidbody;
    public float sidewaysForce = 500f;

   
    public void MoveLeft()
    {



        rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

    }

    public void MoveRight()
    {

        rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

    }
}
