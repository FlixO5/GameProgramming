using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(coinValue);
            
            //GetComponent<AudioSource>()?.Play();

            Destroy(collision.gameObject);
        }
    }
}
