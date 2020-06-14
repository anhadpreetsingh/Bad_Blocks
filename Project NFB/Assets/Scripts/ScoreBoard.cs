using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    RandomSpawn[] randomSpawn;
    public int score = 0;
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
        
    }


    public void UpdateScore(int scoreperdeath)
    {
        randomSpawn = FindObjectsOfType<RandomSpawn>();
        score += scoreperdeath;
        text.text = score.ToString();

        foreach (RandomSpawn platform in randomSpawn)
        {
            if (score != 0 && score % 5 == 0)
            {
                platform.spawnfreq += 1;
            }
        }
        
    }
}
