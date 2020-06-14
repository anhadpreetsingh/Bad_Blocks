using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    TouchControl player;


    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<TouchControl>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }
}
