using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieEnemyScript2 : MonoBehaviour
{

    public GameObject target;

    public int speed = 10000;
    public float distance;
    public float minimumDistance = 12f;
    public float enemyHash;

    public Transform targetpl;


    void Start()
    {
        targetpl = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //target.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        GameObject spawn = GameObject.FindGameObjectWithTag("spawnleft");
        Spawn2 script2 = spawn.GetComponent<Spawn2>();
        enemyHash = script2.enemyId + 1;
        target = GameObject.Find("Enemy " + script2.enemyId + "(Clone)");
        //Debug.Log(enemyHash);


   


        //replace 0 with current zombie

    }

    void Update()
    {
        if (targetpl.transform.position.x >= transform.position.x)
        {
           // print("hellothere");
            transform.rotation = Quaternion.Euler(0f, 180f, 0.0f);

        }
        if (targetpl.transform.position.x <= transform.position.x)
        {
           // print("hellothere");
            transform.rotation = Quaternion.Euler(0f, 0f, 0.0f);

        }


        //Debug.Log(targetpl.transform.position.x);
        //Debug.Log(enemyHash);
        target = GameObject.Find("Enemy " + enemyHash + "(Clone)");
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            target.transform.position = new Vector3(target.transform.position.x, target.transform.position.y + (float)0.1, target.transform.position.z);
        }
        if (target == null)
        {
            Destroy(gameObject);
        }

        //distance = Vector3.Distance(target.transform.position, transform.position);
        //if (distance <= minimumDistance)
        //{
        //}
    }
}
