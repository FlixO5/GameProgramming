using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }    
    IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(objectToSpawn, new Vector2(10, 1), Quaternion.identity);
    }
    
}
