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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            score += 100;
        }
        else if (other.gameObject.CompareTag("SpecialCollectible"))
        {
            Destroy(other.gameObject);
            score += 1000;
        }
        scoreDisplay.text = "Score: " + score;
    }
}
