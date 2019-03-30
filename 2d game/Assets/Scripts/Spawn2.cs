using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn2 : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject enemyprefab;
    public GameObject ZombiePrefab;



    public float starttime = 2;
    public int Limit = 100;
    public int gap = 1;
    public int entCap = 0;
    public int enemyId = -1;

    void Start()
    {
        starttime = Mathf.Round(Time.time);
    }

    void Update()
    {
        if (starttime == Mathf.Round(Time.time))
        {
            starttime += gap + Random.Range(0, 3);

            if (entCap <= Limit)
            {
                enemyprefab.name = "Enemy " + enemyId;
                SpawnEnemy();
                entCap = entCap + 1;
                enemyId--;
            }

        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyprefab, SpawnPoint.position, SpawnPoint.rotation);
        Instantiate(ZombiePrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
}
