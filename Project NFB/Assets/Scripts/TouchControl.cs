using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    float zDist = 4.5f;
    [SerializeField] float speed = 5f;
    [SerializeField] float xRange = 5f;
    [SerializeField] float yRange = 5f;
    [SerializeField] float yRotRange = 30f;
    [SerializeField] float xRotRange = 30f;


    public bool isDead = false;


    Vector3 initPos;
    Vector3 movePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && !isDead)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                initPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, zDist));
                movePos = initPos;

                print("Began");
            }

            else if(touch.phase == TouchPhase.Moved)
            {
                movePos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, zDist));

                print("moving");
            }

            Vector3 diffpos = movePos - initPos;
            float scaleX = diffpos.x * speed * Time.deltaTime;
            float scaleY = diffpos.y * speed * Time.deltaTime;

            float clampedX = Mathf.Clamp(scaleX + transform.localPosition.x, -xRange, xRange);
            float clampedY = Mathf.Clamp(scaleY + transform.localPosition.y, -1f, yRange);

            transform.localPosition = new Vector3(clampedX, clampedY, zDist);


            float degPerUnitX = yRotRange / xRange;

            float degPerFrameY = degPerUnitX * clampedX;

            float degPerUnitY = xRotRange / yRange;

            float degPerFrameX = degPerUnitY * clampedY;



            

            

            transform.localRotation = Quaternion.Euler(-degPerFrameX, degPerFrameY, 0);
            
        }

        else
        {
            
        }
    }

}   
