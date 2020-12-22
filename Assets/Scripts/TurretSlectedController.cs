using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSlectedController : MonoBehaviour
{

    public LayerMask turretSlot;
    public LayerMask floor;

    GameObject slot;
    public GameObject turret;

    public bool turretTouch = false;

    SlotCrontoller slotCl;

    void Start()
    {
        turretTouch = true;
    }


    void Update()
    {

        if (turretTouch == true)
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, floor)) ;
            {
                transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                //Debug.Log("1");


            }
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity,turretSlot)) 
            {
               slot = hit.collider.gameObject;
               slotCl = slot.transform.GetComponent<SlotCrontoller>();
               

                Vector3 turretPosition = new Vector3(slot.transform.position.x, transform.position.y, slot.transform.position.z);
                transform.position = turretPosition;

                if (Input.GetMouseButtonDown(0) && slotCl.isFull == false)
                {
                    Instantiate(turret, turretPosition, Quaternion.identity);
                    turretTouch = false;

                    Debug.Log("llega al &&");
                    slotCl.slotState();

                    Destroy(gameObject);
                }
            }
        }
    }
}
