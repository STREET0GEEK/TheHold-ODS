using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieEnemyScript : MonoBehaviour {

    public GameObject target;

    public int speed = 10000;
    public float distance;
    public float minimumDistance = 12f;
    public float enemyHash;

    public Transform targetpl;


    void Start()
    {
        targetpl = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        GameObject spawn = GameObject.FindGameObjectWithTag("spawnright");
        Spawn script = spawn.GetComponent<Spawn>();
        enemyHash = script.enemyId - 1;
        target = GameObject.Find("Enemy " + script.enemyId + "(Clone)");

    }

	void Update () {

        if (targetpl.transform.position.x >= transform.position.x)
        {
            //print("hellothere");
            transform.rotation = Quaternion.Euler(0f, 180f, 0.0f);

        }
        if (targetpl.transform.position.x <= transform.position.x)
        {
            //print("hellothere");
            transform.rotation = Quaternion.Euler(0f, 0f, 0.0f);

        }


        target = GameObject.Find("Enemy " + enemyHash + "(Clone)");
        if (target != null)
        {
//            Debug.Log(target.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            //target.transform.position = new Vector3(target.transform.position.x, target.transform.position.y +(float) 0.1, target.transform.position.z);
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
