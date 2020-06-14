using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    Camera camera1;
    [SerializeField] float delay = 2f;
    // Start is called before the first frame update
    void Start()
    {
        camera1 = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(camera1.transform.position.z >= transform.position.z)
        {
            Destroy(gameObject, delay);
        }
        
    }
}
