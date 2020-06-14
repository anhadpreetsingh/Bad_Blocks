using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDeath : MonoBehaviour
{
    [SerializeField] ScoreBoard scoreBoard;
    [SerializeField] int scoreperdeath = 1;
    [SerializeField] GameObject gameObject1;
    [SerializeField] ParticleSystem deathFX;
    Parent parent;

    // Start is called before the first frame update
    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        parent = FindObjectOfType<Parent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ParticleSystem fx = Instantiate(deathFX, transform.position, Quaternion.identity);
            fx.transform.parent = parent.transform;

            scoreBoard.UpdateScore(scoreperdeath);
            Destroy(gameObject1);
        }
    }
}
