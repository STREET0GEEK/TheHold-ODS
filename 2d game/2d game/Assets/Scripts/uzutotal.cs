using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uzutotal : MonoBehaviour
{
    public int totalbulletsleftuzi;


    // Update is called once per frame
    void Update()
    {
        GameObject usi = GameObject.Find("Ak47");
        GUN gunScript = usi.GetComponent<GUN>();

        totalbulletsleftuzi = 200 - gunScript.totalbulletsUZI;

        GetComponent<Text>().text = totalbulletsleftuzi + "";
        if (totalbulletsleftuzi < 0)
        {
            GetComponent<Text>().text = 0 + "";
        }
    }
}
