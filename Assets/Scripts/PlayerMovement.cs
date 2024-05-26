using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 1f;


    private Rigidbody2D physicsBody = null;


    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void moveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -speed;

        physicsBody.velocity = newVelocity;
    }

    public void moveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = speed;

        physicsBody.velocity = newVelocity;
    }
}
