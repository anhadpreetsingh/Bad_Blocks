using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour
{

    [SerializeField] int scoreperdeath = 1;
    [SerializeField] ScoreBoard scoreBoard;
    [SerializeField] ParticleSystem deathFX;
    [SerializeField] Parent parent;
    
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
    private void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.tag == "PlayerBullets")
        {
            ParticleSystem fx = Instantiate(deathFX, transform.position, Quaternion.identity);

            fx.transform.parent = parent.transform;
            

            scoreBoard.UpdateScore(scoreperdeath);
            Destroy(gameObject);
        }
    }
}
