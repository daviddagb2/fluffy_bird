using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float velocity = 1;
    private Rigidbody2D rigigbody;
    public GameController mainGameController;
    public AudioSource audioSource;
    public AudioClip pling;

    // Start is called before the first frame update
    void Start()
    {
        rigigbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rigigbody.velocity = Vector2.up * velocity;

            if (!audioSource.isPlaying && Time.timeScale > 0)
            {
                audioSource.PlayOneShot(pling, 0.5f);
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        mainGameController.hitSound();
        mainGameController.gameOver();
    }

}
