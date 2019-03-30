using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {
    public GameObject SlotPre;
    public Transform Slot;
    public List<GameObject> SlotList = new List<GameObject>();

    public int gunPos = 0;

	void Start () {
        SpawnSlots();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxis("ScrollWheel"));
        if (Mathf.Abs(Input.GetAxis("ScrollWheel")) > 0)
        {
            //Debug.Log("im Scrolling Bois");
            gunPos++;
            if (gunPos >= 5)
            {
                gunPos = 0;

            }
            //SlotList[0].
        }

	}
    void SpawnSlots()
    {
        Vector3 pos = new Vector3(Slot.position.x , Slot.position.y, Slot.position.z);
        for (int i = 0; i <= 4; i++)
        {
            //change 4 to number of guns
            SlotPre.name = "clone " + i;
             
            Instantiate(SlotPre, pos, Slot.rotation);

            SlotList.Add(SlotPre);
            pos.x += 1;

        }
    }
}
