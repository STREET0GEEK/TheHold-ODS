using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateGun : MonoBehaviour {
    public Vector3 mouse_pos;
    public Vector3 object_pos;

    public Transform target;

    public PlayerScript pScript;

    public float angle;
    public float limit;
    public float recoil = 0.1f;


    void Awake()
    {
       // pScript = GetComponent<PlayerScript>();
    }
    void Update () {
        //Debug.Log(pScript.turningl);
        mouse_pos = Input.mousePosition;
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        mouse_pos.z = 5.23f;
        object_pos = Camera.main.WorldToScreenPoint(target.position);

        if (pScript.turningl == true)
        {
                angle = Mathf.Atan2(-mouse_pos.y, -mouse_pos.x) * Mathf.Rad2Deg;
                
        }
        if (pScript.turningl == false)
        {
                angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
        // Debug.Log(target.rotation.z);
    }
}
