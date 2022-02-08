using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(ScoreLogic.score > 20)
        {
            //velocity -= 0.5;
        }

        transform.position += Vector3.left * velocity * Time.deltaTime;
        
    }
}
