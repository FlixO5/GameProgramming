using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private DeathZone respawn;
    void Awake()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<DeathZone>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DeathZone.respawnPoint = this.gameObject;
        }
    }
}
