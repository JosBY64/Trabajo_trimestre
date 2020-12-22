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

   
    void Update()
    {
        
    }

    public void slotState ()
    {
        isFull = true;
    }
}
