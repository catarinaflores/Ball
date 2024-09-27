using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

        RandomDirection();

        InitBall();
    }

    public virtual void InitBall()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);

        Vector2 randomDirection = new Vector2(randomX, randomY).normalized;

        rb.velocity = randomDirection * speed;
    }
}
