using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{

    public float speed = 20f;
    public int enemyDamageAmount = 1;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 5f);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        EnemyHealth Enemyhitbox = hitInfo.GetComponent<EnemyHealth>();
        if (Enemyhitbox != null)
        {
            Enemyhitbox.EnemyDamage(enemyDamageAmount);
        }    
    }
}
