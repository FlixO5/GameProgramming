using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreDisplay;
    int score;
    void Awake()
    {
        
    }
    public void AddScore(int value)
    {
        score += value;
        scoreDisplay.text = "Score: " + score;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            AddScore(100);
        }
        else if (other.gameObject.CompareTag("Respawn"))
        {
            AddScore(-50);
        }

    }
    public int GetScore()
    {
        return score;
    }

}
