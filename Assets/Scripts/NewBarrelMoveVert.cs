using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBarrelMoveVert : MonoBehaviour
{
    public Rigidbody rig;


    void Update()
    {
       
    }
    public void StartBarr()
    {
        rig.AddForce(0, 1000, 0);
    }
}
