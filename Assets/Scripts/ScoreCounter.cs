using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoretext.text = "Score: " + score;
    }

    public void UpdateScore()
    {
        score += 1;
        scoretext.text = "Score: " + score;
    }
}
