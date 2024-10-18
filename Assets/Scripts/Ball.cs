using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    private Vector2 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

        RandomDirection();

        InitBall();

        originalScale = transform.localScale;

        GameManager.OnShrinkEnemyBalls += Shrink;
        GameManager.OnRestoreEnemyBalls += GrowBack;
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

    void OnDestroy()
    {
        GameManager.OnShrinkEnemyBalls -= Shrink;
        GameManager.OnRestoreEnemyBalls -= GrowBack;
    }

    public void Shrink()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            transform.localScale = originalScale * 0.5f;
        }
    }

    public void GrowBack()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            transform.localScale = originalScale;
        }
    }
}
