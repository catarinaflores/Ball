using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int timer;
    public static GameManager instance;

    public delegate void EnemyDelegate();
    public static event EnemyDelegate OnShrinkEnemyBalls;
    public static event EnemyDelegate OnRestoreEnemyBalls;

    [SerializeField] GameObject powerUp;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad (this);
            instance = this;
        }
        else
        {
            Destroy (gameObject);
        }
        score = 0;
    }

    public void UpdateScore()
    {
        score += 1;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SpawnPowerUp()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        Instantiate(powerUp, spawnPos, Quaternion.identity);

        Debug.Log("Power up spawned by Game Manager.");
    }


    public void ShrinkEnemyBalls()
    {
        OnShrinkEnemyBalls?.Invoke();
        Invoke("RestoreEnemyBalls", 10f);
    }

    private void RestoreEnemyBalls()
    {
        OnRestoreEnemyBalls?.Invoke();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
