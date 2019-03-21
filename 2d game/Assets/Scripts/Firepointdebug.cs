using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepointdebug : MonoBehaviour {
    public GameObject pl;
    public GameObject fp;
    public bool shootRight; 
    // Use this for initialization
    void Start () {
        pl = GameObject.FindGameObjectWithTag("Player");
        fp = GameObject.FindGameObjectWithTag("firepoint");
    }
	
	// Update is called once per frame
	void Update () {
        //if (pl.transform.localScale.x == 0.5 && fp.transform.localRotation.y != 180)
        //{
        //    fp.transform.Rotate(0f, 180, 0f);
        //    shootRight = true;
        //}
        //if (pl.transform.localScale.x == -0.5 && fp.transform.localRotation.y != 180)
        //{
        //    fp.transform.Rotate(0f, 0f, 0f);
        //    shootRight = false;
        //}
	}
}
