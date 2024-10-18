using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        UpdateHighScoreText();
    }

    public void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + GameManager.instance.highScore;
    }

    // Update is called once per frame
    /* void Update()
    {
        highScoreText.text = "High Score: " + GameManager.instance.highScore;
    } */
}
