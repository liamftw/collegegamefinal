using System.Collections;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("HIT!");

            // Play the audio clip
            if (source != null && clip != null)
            {
                source.PlayOneShot(clip);
            }
        }
    }
}
