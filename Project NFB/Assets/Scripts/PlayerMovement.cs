using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float rangex = 5f;
    [SerializeField] float rangey = 5f;
    [SerializeField] float yawrange = 10f;
    [SerializeField] float pitchrange = -10f;
    [SerializeField] float pitchfactor = 10f;
    [SerializeField] float rollfactor = 10f;
    [SerializeField] float yawfactor = 10f;

    public bool isdead = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float xthrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float ythrow = CrossPlatformInputManager.GetAxis("Vertical");
        
        if(!isdead)
        {
            ProcessMovement(xthrow, ythrow);
        }

        
   
    }

    

    private void ProcessMovement(float xthrow, float ythrow)
    {
        

        float disteachframex = xthrow * speed * Time.deltaTime;
        float disteachframey = ythrow * speed * Time.deltaTime;
        float rawx = disteachframex + transform.localPosition.x;
        float rawy = disteachframey + transform.localPosition.y;

        float clampedx = Mathf.Clamp(rawx, -rangex, rangex);
        float clampedy = Mathf.Clamp(rawy, -1f, rangey);
        float clampedxrot = transform.localRotation.x + (pitchrange / rangey) * clampedy;
        float clampedyrot = transform.localRotation.y + (yawrange / rangex) * clampedx;


        transform.localPosition = new Vector3(clampedx, clampedy, transform.localPosition.z);


        transform.localRotation = Quaternion.Euler(clampedxrot + pitchfactor * ythrow, clampedyrot + yawfactor * xthrow, transform.localRotation.z + rollfactor * xthrow);
    }
}

