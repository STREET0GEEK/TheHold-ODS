using UnityEngine;
using System.Collections;
using System;

public class GUN : MonoBehaviour
{
    public static GUN gunscript;
    public GameObject BulletPre;
    public GameObject AK47pre;
    public GameObject PistolPre;
    public GameObject UZIPre;

    public Transform firepoint;


    public GameObject pl;

    public float speed = 20;
    public string gun = "ak47";
    public string GunSelect = "clone 0(Clone)";
    public bool shooting = false;

    public float bulletspeed = 10;

    public int numofbulletspistol;
    public int numofbulletsak47;
    public int numofbulletsUZI;

    public GameObject PistolSpritered;


    
    private void Start()

    {
        //bulletspeed == Random.Range(10, 100);
        PistolPre.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        AK47pre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        UZIPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;


        pl = GameObject.FindGameObjectWithTag("Player");
        Scroller scrollerposition = GetComponent<Scroller>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //        Debug.Log(numofbullets);
        // GunSelect = scrollpos.gunPos;

        if (Input.GetButton("Fire1")){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Debug.Log(hit.collider.gameObject.name);
                // GunSelect = Int32.Parse(hit.collider.gameObject.name);
                //Debug.Log(hit.collider.gameObject.GetInstanceID());
                GunSelect = hit.collider.gameObject.name;
            }
           

            switch(GunSelect)
            {
                case "clone 0(Clone)":
                    //Debug.Log("case1");
                    PistolPre.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    AK47pre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    UZIPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    shoot();
                    break;

                case "clone 1(Clone)":
                    //Debug.Log("case2");
                    AK47pre.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    PistolPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    UZIPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    ak47();
                    break;

                case "clone 2(Clone)":
                    UZIPre.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    AK47pre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    PistolPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    UZI();
                    break;

                case "clone 3(Clone)":
                    AK47pre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    PistolPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    UZIPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;

                    break;
                case "clone 4(Clone)":
                    AK47pre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    PistolPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    UZIPre.gameObject.GetComponent<SpriteRenderer>().enabled = false;

                    break;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        { 
            if (GunSelect == "clone 0(Clone)")
            {
                numofbulletspistol = 0;
            }
            if (GunSelect == "clone 1(Clone)")
            {
                numofbulletsak47 = 0;
            }
            if (GunSelect == "clone 2(Clone)")
            {
                numofbulletsUZI = 0;
            }
            //if (GunSelect == "clone 3(Clone)")
            //{

            //}
            //if (GunSelect == "clone 4(Clone)")
            //{

            //}
        }


    }

    void shoot()
    {
        if (numofbulletspistol <= 12) 
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(BulletPre, firepoint.position, firepoint.rotation);
                numofbulletspistol += 1;

            }
        }




    }
    void ak47()
    {
        if (numofbulletsak47 <= 30)
        {

            if (Input.GetButton("Fire1"))
            {
                shooting = true;
                Instantiate(BulletPre, firepoint.position, firepoint.rotation);
                numofbulletsak47 += 1;
                //yield return new WaitForSeconds (bulletspeed);
                //System.Threading.Thread.Sleep();
            }
        }
        //if (numofbulletsak47 == 30)
        //{
            //wait();
            //numofbulletsak47 = 0;

        //}

    }
    void UZI()
    {
        if (numofbulletsUZI <= 20)
        {
            //  for(int i = 0; i <= 1; i++)
            //  {
            Instantiate(BulletPre, firepoint.position, firepoint.rotation);
            numofbulletsUZI += 1;
            
        }
        //  }
    }

    //void wait(float loadtime)
    //{
    //    float timeelapsed = 0;
    //    while(timeelapsed <= loadtime)
    //    {
    //        timeelapsed = timeelapsed + Time.deltaTime;
    //    }
    //}
}