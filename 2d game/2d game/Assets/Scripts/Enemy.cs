using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed;
    public float distance = 4;
    public float Health = 100;



    public Transform target;

	void Start () {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

         
    }
    void Update()
    {


        // if (target.transform.position.x >= transform.position.x)
        // { 
        //transform.LookAt(target);
        // }
        //bascially check players positiion constatly
        // RaycastHit hit;
        if (Vector2.Distance(transform.position, target.position) > distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
    public void takeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

}
