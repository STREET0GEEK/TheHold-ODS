using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class healthtext : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        GameObject thePlayer = GameObject.Find("Player");
        PlayerScript playerScript = thePlayer.GetComponent<PlayerScript>();
        //Debug.Log(playerScript.Health);
        GetComponent<TextMeshProUGUI>().text = "Health: " + playerScript.Health;
        if(playerScript.Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}

