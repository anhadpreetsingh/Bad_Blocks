using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinite : MonoBehaviour
{

    Camera camera1;
    
    bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        camera1 = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {   if (!once)
        {
            
            if (camera1.transform.position.z >= transform.position.z - 50)
            {
                Instantiate(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z + 100), Quaternion.identity);
                once = true;
                
            }

        }

        if(camera1.transform.position.z >= transform.position.z + 50)
        {
            Destroy(gameObject);
        }
    }


    
}
