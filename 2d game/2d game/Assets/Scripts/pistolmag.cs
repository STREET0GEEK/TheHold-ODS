using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pistolmag : MonoBehaviour {
    public int bulletsleftpistol;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject pistol = GameObject.Find("Ak47");
        GUN gunScript = pistol.GetComponent<GUN>();
        //Debug.Log(gunScript.numofbulletsak47);
        bulletsleftpistol = 12 - gunScript.numofbulletspistol;
        GetComponent<Text>().text = bulletsleftpistol + "/12";
    }
}
