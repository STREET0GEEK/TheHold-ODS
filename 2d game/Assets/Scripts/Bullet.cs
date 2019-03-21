using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 10f;

    public int damage = 20;
    public int zslide;

    public Rigidbody2D rb;
    public Rigidbody2D bl;

    void Start () {
        transform.Translate(0f, 0f, zslide);
        rb.velocity = transform.right * speed;
        bl = GameObject.FindGameObjectWithTag("bullet").GetComponent<Rigidbody2D>();
    }
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.takeDamage(damage);
            Destroy(gameObject);
        }
        if(hitInfo.name != "Player")
        {
            Destroy(gameObject);
        }
    }
}