using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpDrive : MonoBehaviour
{

    public ParticleSystem part;
    private void OnTriggerEnter(Collider other)
    {
        part.Play();
    }
}
