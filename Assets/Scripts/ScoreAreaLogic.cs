using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAreaLogic : MonoBehaviour
{
    AudioController audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("AudioControl").GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreLogic.score++;
        audioSource.playSoundScore();

    }
}
