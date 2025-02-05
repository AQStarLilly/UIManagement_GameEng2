using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;      
    }

    public void addScore()
    {
        score += 15;
        ScoreUpdate();
    }

    public void reduceScore()
    {
        score -= 15;
        ScoreUpdate();
    }

    public void resetScore()
    {
        score = 0;
        ScoreUpdate();
    }

    void ScoreUpdate()
    {
        scoreText.text = score.ToString();
    }
}
