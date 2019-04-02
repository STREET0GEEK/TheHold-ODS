using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uzimag : MonoBehaviour {
    public int numberleftUZI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject UZI = GameObject.Find("Ak47");
        GUN gunScript = UZI.GetComponent<GUN>();
        //Debug.Log(gunScript.numofbulletsak47);
        numberleftUZI = 20 - gunScript.numofbulletsUZI;
        GetComponent<Text>().text = numberleftUZI + "/20";
    }
}
