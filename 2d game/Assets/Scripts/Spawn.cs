using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public Transform SpawnPoint;
    public GameObject enemyprefab;
    
    

    public float starttime = 2;
    public int Limit = 100;
    public int gap = 1;
    public int entCap = 0;

    void Start()
    {
        starttime = Mathf.Round(Time.time);
    }

    void Update () {
        if (starttime == Mathf.Round(Time.time))
        {
            starttime += gap + Random.Range(0, 3);

            if(entCap <= Limit)
            {
                SpawnEnemy();
                entCap = entCap + 1;
            }
            
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyprefab, SpawnPoint.position, SpawnPoint.rotation);
    }
}
