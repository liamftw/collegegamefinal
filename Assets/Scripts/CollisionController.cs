using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CollisionController : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    private playerHealth playerHealthScript;

    void Start()
    {
        playerHealthScript = FindObjectOfType<playerHealth>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("HIT!");

            // script to take away 1 heart after a collision
            if (playerHealthScript != null)
            {
                playerHealthScript.clydeHealth -= 1;
                // make sure that the health doesnt go below zero
                if (playerHealthScript.clydeHealth < 0)
                {
                    playerHealthScript.clydeHealth = 0;
                }
            }

            // play the audio clip
            if (source != null && clip != null)
            {
                source.PlayOneShot(clip);
            }
        }
    }
}
