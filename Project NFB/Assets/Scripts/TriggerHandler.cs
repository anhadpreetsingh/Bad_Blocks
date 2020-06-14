using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem deathFX;
    Parent parent;

    TouchControl touchControl;


    // Start is called before the first frame update
    
    void Start()
    {
        
        parent = FindObjectOfType<Parent>();
        touchControl = FindObjectOfType<TouchControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Ring")
        {
            
            ParticleSystem fx = Instantiate(deathFX, transform.position, Quaternion.identity);
            fx.transform.parent = parent.transform;
            print("dead");
            touchControl.isDead = true;
        }

        if(other.gameObject.tag == "Pass")
        {
            print("passed");
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.tag == "ebullets")
        {
            ParticleSystem fx = Instantiate(deathFX, transform.position, Quaternion.identity);
            fx.transform.parent = parent.transform;
            print("dead");
            touchControl.isDead = true;
        }
    }
}
