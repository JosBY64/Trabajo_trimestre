using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroScript : MonoBehaviour
{

    private float elapsedTime = 1;
    private int time = 0;

    void Start()
    {
        
    }

    void Update()
    {

        if (elapsedTime <= 0)
        {
            time++;
            //Debug.Log(time);
            elapsedTime = 1;
            textDie();
        }

        elapsedTime -= Time.deltaTime;


       void textDie()
        {
            if (time % 1 == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
