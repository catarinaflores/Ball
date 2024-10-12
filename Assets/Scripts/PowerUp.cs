using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Vector2 newSize = new Vector2(0.25f, 0.25f);
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RedBallBehavior redBall = FindObjectOfType<RedBallBehavior>();

            if (redBall != null)
            {
                StartCoroutine(ChangeBallSizeTemporarily(redBall));
                Debug.Log("Power up collected, red ball size changed.");
            }

            Destroy(gameObject);
        }
    }

    private IEnumerator ChangeBallSizeTemporarily(RedBallBehavior redBall)
    {
        Vector2 originalSize = redBall.transform.localScale;

        redBall.SetBallSize(newSize);

        yield return new WaitForSeconds(10f);

        redBall.SetBallSize(originalSize);
    }
}
