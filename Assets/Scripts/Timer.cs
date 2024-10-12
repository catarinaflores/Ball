using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timer = 30f;
    public TextMeshProUGUI timerText;
    public float timeToSpawn = 10f;

    // [SerializeField] GameObject powerUp;

    private bool objectSpawned = false; // To ensure the object is spawned only once
    // private float spawnThreshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start method is called.");
        // StartCoroutine(SimpleTestCoroutine());
        StartCoroutine(SpawnPowerUpAfterDelay());
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("f0");
        Debug.Log("Current time: " + timer);


        /* if (Mathf.Abs(timer - timeToSpawn) <= spawnThreshold && !objectSpawned)
        {
            Debug.Log("Spawning Power Up! Timer: " + timer);

            SpawnPowerUp();

            objectSpawned = true;
        } */


        if (timer <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }

    IEnumerator SpawnPowerUpAfterDelay()
    {
        Debug.Log("Coroutine started, waiting for " + timeToSpawn + " seconds");
        yield return new WaitForSeconds(timeToSpawn);

        if (GameManager.instance != null && !objectSpawned)
        {
            GameManager.instance.SpawnPowerUp();
            objectSpawned = true;
        }

        objectSpawned = true;

        Debug.Log("Power Up spawned after 10 seconds.");
    }

    /* IEnumerator SimpleTestCoroutine()
    {
        Debug.Log("Coroutine started, waiting for 10 seconds.");
        yield return new WaitForSeconds(10f);
        Debug.Log("Coroutine finished waiting.");
    }*/
}
