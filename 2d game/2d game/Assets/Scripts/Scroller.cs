using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {
    public GameObject SlotPre;
    public Transform Slot;
    public GameObject slotGO;
    public List<GameObject> SlotList = new List<GameObject>();


    public int gunPos = 0;

    public string GunSelect = "clone 0(Clone)";

    void Start() {
        SpawnSlots();

    }

    // Update is called once per frame
    void Update() {


        if (Mathf.Abs(Input.GetAxis("ScrollWheel")) > 0)
        {
            gunPos++;
            if (gunPos >= 5)
            {
                gunPos = 0;

            }
            //SlotList[0].
        }

        //switch (GunSelect)
        //{
        //    case "clone 0(Clone)":
        //        //Debug.Log("Case 0");
        //        slotGO.gameObject.GetComponent<MeshRenderer>().enabled = false;
        //        break;

        //    case "clone 1(Clone)":
        //        //Debug.Log("Case 1");
        //        break;

        //    case "clone 2(Clone)":
        //        //Debug.Log("Case 2");
        //        break;

        //    case "clone 3(Clone)":
        //        //Debug.Log("Case 3");
        //        break;

        //    case "clone 4(Clone)":
        //        //Debug.Log("Case 4");
        //        break;
        //}
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
