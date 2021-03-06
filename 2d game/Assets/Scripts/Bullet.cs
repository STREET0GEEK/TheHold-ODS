﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 10f;

    public int damage = 20;
    public int zslide;


    public int minusbullets;
    private GUN gunscript;

    public Rigidbody2D rb;
    public Rigidbody2D bl;

    void Start () {
        transform.Translate(0f, 0f, zslide);
        rb.velocity = transform.right * speed;
        bl = GameObject.FindGameObjectWithTag("bullet").GetComponent<Rigidbody2D>();
        gunscript = GetComponent<GUN>();
        
    }
    void Update()
    {
        //GUN.gunscript.numofbullets = GUN.gunscript.numofbullets - minusbullets;
     //   Debug.Log(gunscript.bulletspeed);
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.takeDamage(damage);
            Destroy(gameObject);
           // minusbullets += 1;
        }
        if(hitInfo.name != "Player")
        {
            Destroy(gameObject);
            //minusbullets += 1;
        }
    }



}