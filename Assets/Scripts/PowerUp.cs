using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Vector2 newSize = new Vector2(0.25f, 0.25f);
    public float effectDuration = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.ShrinkEnemyBalls();
            Destroy(gameObject);
        }
    }

    /* private IEnumerator ChangeBallSizeTemporarily(RedBallBehavior redBall)
    {
        Vector2 originalSize = new Vector2(redBall.transform.localScale.x, redBall.transform.localScale.y);

        redBall.SetBallSize(newSize);

        yield return new WaitForSeconds(effectDuration);

        redBall.SetBallSize(new Vector2(originalSize.x, originalSize.y));
    }*/
}
