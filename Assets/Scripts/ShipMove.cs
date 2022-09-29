using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    public Rigidbody rig;


    void Update()
    {
        rig.AddForce(0, 0, -50);
    }
}
