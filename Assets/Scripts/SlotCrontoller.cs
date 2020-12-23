using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotCrontoller : MonoBehaviour
{
    public bool isFull;

    void Start()
    {
        isFull = false;
    }

   
    public void slotState ()
    {
        isFull = true;
    }
}
