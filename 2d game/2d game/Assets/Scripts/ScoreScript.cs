using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour {


	void Start () {
		
	}
	
	void Update () {
        GameObject thePlayer = GameObject.Find("Player");
        PlayerScript playerScript = thePlayer.GetComponent<PlayerScript>();
        GetComponent<Text>().text = "Score: " + playerScript.Score;
    }
}
