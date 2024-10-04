using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    // Start is called before the first frame update

    void Update()
    {
        scoretext.text = "Score: " + GameManager.instance.score.ToString();
    }

}
