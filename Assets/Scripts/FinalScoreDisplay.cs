using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreDisplay : MonoBehaviour
{
    public TMP_Text FinalScoreText;
    int FinalScore;
    // Start is called before the first frame update
    void Start()
    {
        FinalScore = ScoreManager.instance.GetScore();
        FinalScoreText.text = "Final Score: " + FinalScore;

        Destroy(ScoreManager.instance.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
