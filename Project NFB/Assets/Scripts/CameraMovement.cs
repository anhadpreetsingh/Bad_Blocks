using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    

    

    // Update is called once per frame
    void Update()
    {
        float distperframe = speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + distperframe);

        

    }
}
