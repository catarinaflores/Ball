using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int timer;
    public static GameManager instance;


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
    // Update is called once per frame
    void Update()
    {
        
    }
}
