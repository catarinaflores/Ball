using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GreenBallBehavior : Ball
{
    [SerializeField] ScoreCounter score;
    [SerializeField] GameObject redBall;
    [SerializeField] GameObject purpleBall;

    private Transform playerPosition;

    public override void InitBall()
    {
        playerPosition = GameObject.FindWithTag("Player").transform;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score.UpdateScore();

            transform.position = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));

            RandomDirection();
            
            Vector2 randomPosition = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
            
            if (Random.Range(0, 2) == 0)
            {
                Instantiate(redBall, randomPosition, Quaternion.identity);
            }
            else
            {
                GameObject spawnedPurpleBall = Instantiate(purpleBall, randomPosition, Quaternion.identity);


                PurpleBallBehavior purpleBallScript = spawnedPurpleBall.GetComponent<PurpleBallBehavior>();
                if (purpleBallScript != null)
                {
                    purpleBallScript.SetTargetPosition(collision.contacts[0].point);
                }
            }
            
        }
    }
}
