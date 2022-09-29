using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMove : MonoBehaviour
{
    public Rigidbody rig;
    [SerializeField] float xVector = 0;
    [SerializeField] float yVector = 0;
    [SerializeField] float zVector = 0;
    
    void Update()
    {
        rig.AddForce(xVector, yVector, zVector);
    }
}
