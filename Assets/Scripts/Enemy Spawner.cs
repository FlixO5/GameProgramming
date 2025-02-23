using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject object1;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.7f);
            int gambling = Random.Range(0, 2);
            float letsgogambling = Random.Range(-7, 7);
            if(gambling == 0){
                Instantiate(object1, new Vector2(letsgogambling, 7), Quaternion.identity);
            }
        }
    }
}
