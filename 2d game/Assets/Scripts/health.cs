using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {
    public int Health = 100;
    public GameObject pl;

    void Start()
    {
        
    }


    void Update()
    {
        GameObject thePlayer = GameObject.Find("Player");
        PlayerScript playerScript = thePlayer.GetComponent<PlayerScript>();
        //Debug.Log(playerScript.Health);
        if (playerScript.hit == true)
        {
            ouch();
            playerScript.hit = false;
        }
    }

    public void ouch ()
    {
        //Debug.Log("Work");
        transform.Translate(-.382f, 0f, 0f);
        transform.localScale += new Vector3(-.09663f, 0f, 0f);
        
    }


}
