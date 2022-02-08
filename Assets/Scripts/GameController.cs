using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject canvasGameOver;

    //Sound
    public AudioClip soundScore;
    AudioController audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        audioSource = GameObject.Find("AudioControl").GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        canvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void hitSound()
    {
        audioSource.playSoundHit();
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
