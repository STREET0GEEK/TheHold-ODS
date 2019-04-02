using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public float speed = 5f;
    public float jumpForce = 10f;
    public float disGround = 1f;
    public float Health = 100.0f;
    public bool turningl = false;

    public bool hit = false;

    public static float pathLength; 

    public int Damage = 20;

    public GameObject pl;
    public GameObject fp;
    

    public Rigidbody2D ridge;

    //need to figure out how to represent anynumber to the enemy id
    //maybe store in list
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Enemy (Clone)")
        {
            hit = true;
            Health = Health - Damage; 
            
        }
        if (hitInfo.name != "Enemy (Clone)")
        {
            hit = false;
        }

    }


    void Start (){

        

        fp = GameObject.FindGameObjectWithTag("firepoint"); 
        pl = GameObject.FindGameObjectWithTag("Player");
        ridge = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
	}

	void Update () {
       // GameObject spawnscript = GameObject.Find("SpawnPoint Right");
       // Spawn spawnScript = spawnscript.GetComponent<Spawn>();

       // Debug.Log(spawnScript.Limit);
       // Debug.Log(turningl);
        float whore = Input.GetAxisRaw("Horizontal");
        transform.Translate(whore * speed * Time.deltaTime, 0f, 0f);
        if (Input.GetAxisRaw("Jump") != 0 && isGrounded()) { 
        
            ridge.AddForce(new Vector2(0f,jumpForce));
           
        }

        if(Input.GetKeyDown(KeyCode.A) && pl.transform.localScale.x > 0)
        {
            Vector3 newScale = pl.transform.localScale;
            newScale.x *= -1;
            pl.transform.localScale = newScale;
            fp.transform.Rotate(0f, 180, 0f);
            turningl = true;
        }
        if (Input.GetKeyDown(KeyCode.D) && pl.transform.localScale.x < 0)
        {
            Vector3 newScale = pl.transform.localScale;
            newScale.x *= -1;
            pl.transform.localScale = newScale;
            fp.transform.Rotate(0f, -180, 0f);
            turningl = false;
        }
            
    }
    bool isGrounded()
    {
        //Vector2 pos = new Vector2(transform.position.x, transform.position.y - (float)0.1);

        return Physics2D.Raycast(transform.position, Vector2.down, disGround);
    }
    
}
