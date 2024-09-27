using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBallBehavior : RedBallBehavior
{
    private Vector2 targetPosition;    // Position where the player hit the green ball
    private Transform playerPosition;  // Reference to the player's current position

    public override void InitBall()
    {
        playerPosition = GameObject.FindWithTag("Player").transform;

        // Start by moving towards the initial hit target position
        MoveTowardsTarget();
    }

    // Update is called once per frame
    void Update()
    {
        // You can handle additional updates here if needed, like checking for collisions or player position.
    }

    public void SetTargetPosition(Vector2 hitPosition)
    {
        // Set the initial target to the hit position
        targetPosition = hitPosition;
    }

    void MoveTowardsTarget()
    {
        // Calculate the direction towards the target position
        Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;

        // Use Rigidbody2D to apply movement towards the target
        rb.velocity = direction * 5f; // Adjust speed as necessary
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            // When hitting a wall, change the target to the player's current position
            targetPosition = playerPosition.position;

            // Move towards the new player position
            MoveTowardsTarget();
        }
    }
}