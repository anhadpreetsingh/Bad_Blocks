using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    public float spawnfreq = 5f;
    Camera camera1;
    ParentObstacles parent;
    // Start is called before the first frame update
    void Start()
    {
        camera1 = FindObjectOfType<Camera>();
        parent = FindObjectOfType<ParentObstacles>();
    }

    // Update is called once per frame
    void Update()
    {

        float randnum = Random.Range(0, 5/Time.deltaTime);
        if(randnum <= spawnfreq)
        {
            float yrot = 0f;
            float randx = Random.Range(-3, 3);
            float randy = Random.Range(2, 5);
            int randz = Random.Range(30, 45);
            int randobstacle = Random.Range(0, obstacles.Length);
            if (randobstacle == 1)
            {
                yrot = 90f;
            }

            GameObject ob = Instantiate(obstacles[randobstacle], new Vector3(randx, randy, camera1.transform.position.z + randz), Quaternion.Euler(0, yrot, 0));
            ob.transform.parent = parent.transform;
        }
    }
}
