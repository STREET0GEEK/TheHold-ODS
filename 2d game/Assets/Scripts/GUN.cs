using UnityEngine;
using System.Collections;

public class GUN : MonoBehaviour
{
    public GameObject BulletPre;
    public Transform firepoint;
    public GameObject pl;
    public float speed = 20;
    public string gun = "ak47";
    public int GunSelect = 1;
    
    private void Start()

    { 
    pl = GameObject.FindGameObjectWithTag("Player");
  //  scroller = GameObject.FindGameObjectWithTag("Scroller");

    }

    // Update is called once per frame
    void Update()
    {
        
        
//        GunSelect = scrollpos.gunPos;
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
            switch(GunSelect)
            {
                case 1:
                    //Debug.Log("case1");
                    break;

                case 2:
                    //Debug.Log("case2");
                    break;
            }
        }
    }

    void shoot()
    {

        Instantiate(BulletPre, firepoint.position, firepoint.rotation);

    }
    void ak47()
    {
       //Debug.Log("hellothere"); 

    }
    void Mini()
    {

    }
}