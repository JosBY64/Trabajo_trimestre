using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    private float elapsedTime = 1;
    private int time = 0;
    
 
   
    void Update()
    {

      if (elapsedTime <= 0)
        {
            time++;
            //Debug.Log(time);
            elapsedTime = 1;
            enemySpawn();
        }

        elapsedTime -= Time.deltaTime;

    }


    private void enemySpawn()
    {
        if (time % 5 == 0)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
