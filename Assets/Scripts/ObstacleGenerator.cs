using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public float maxTime = 1;
    private float initialTime = 0;
    public GameObject obstacle;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(newObstacle, 10);
    }

    // Update is called once per frame
    void Update()
    {

        if(initialTime > maxTime)
        {
            GameObject newObstacle = Instantiate(obstacle);
            newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObstacle, 10);
            initialTime = 0;
        }
        else
        {
            initialTime += Time.deltaTime;
        }
        
    }
}
