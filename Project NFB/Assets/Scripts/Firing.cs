using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Firing : MonoBehaviour
{
    [SerializeField] ParticleSystem gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem.EmissionModule emissionModule = gun.emission;
        if(Input.touchCount>0)
        {
            emissionModule.enabled = true;
        }
        else
        {
            emissionModule.enabled = false;
        }
    }
}
