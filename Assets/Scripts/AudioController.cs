using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clipScore;
    public AudioClip clipSwing;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSoundScore()
    {
        audioSource.clip = clipScore;
        audioSource.Play();
    }

    public void playSoundHit()
    {
        audioSource.clip = clipSwing;
        audioSource.PlayOneShot(clipSwing, 1);
    }
}
