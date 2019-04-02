using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ak47total : MonoBehaviour {
    public int totalbulletsleftak47;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject ak47 = GameObject.Find("Ak47");
        GUN gunScript = ak47.GetComponent<GUN>();

        totalbulletsleftak47 = 180 - gunScript.totalbulletsak47;

        GetComponent<Text>().text = totalbulletsleftak47 + "";
        if (totalbulletsleftak47 < 0)
        {
            GetComponent<Text>().text = 0 + "";
        }
    }
}
