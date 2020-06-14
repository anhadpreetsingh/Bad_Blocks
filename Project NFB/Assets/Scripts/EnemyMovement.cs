using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Range(-1, 1)] [SerializeField] float oscillation;
    [SerializeField] float period = 2f;
    Vector3 startingpos;
    
    // Start is called before the first frame update
    void Start()
    {
        startingpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycles = Time.time / period;
        oscillation = Mathf.Sin(2 * Mathf.PI * cycles);
        Vector3 offset = oscillation * new Vector3(1,0,0);

        transform.position = startingpos + offset;
    }
}
