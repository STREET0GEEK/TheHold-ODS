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
	
	void Update () {
	}
}
