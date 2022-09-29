using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMoveVert : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    


    private void OnTriggerEnter(Collider other)
    {
        obj1.GetComponentInChildren<NewBarrelMoveVert>().StartBarr();
        obj2.GetComponentInChildren<NewBarrelMoveVert>().StartBarr();
        obj3.GetComponentInChildren<NewBarrelMoveVert>().StartBarr();
        obj4.GetComponentInChildren<NewBarrelMoveVert>().StartBarr();
        obj5.GetComponentInChildren<NewBarrelMoveVert>().StartBarr();
        obj6.GetComponentInChildren<NewBarrelMoveVert>().StartBarr();
        obj7.GetComponentInChildren<NewBarrelMoveVert>().StartBarr();
     
    }



}
