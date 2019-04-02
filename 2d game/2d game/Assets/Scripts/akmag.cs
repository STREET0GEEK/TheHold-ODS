using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class akmag : MonoBehaviour {
    public int numberleftak47;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GameObject Ak47 = GameObject.Find("Ak47");
        GUN gunScript = Ak47.GetComponent<GUN>();
        //Debug.Log(gunScript.numofbulletsak47);
        numberleftak47 = 30 - gunScript.numofbulletsak47;
        GetComponent<Text>().text = numberleftak47 + "/30";
    }
}
