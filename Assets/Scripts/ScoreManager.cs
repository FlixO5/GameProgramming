using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreDisplay;
    int score;

    public void AddScore(int value)
    {
        score += value;
        scoreDisplay.text = "Score: " + score.ToString("D6");
    }
}
