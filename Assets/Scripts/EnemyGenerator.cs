using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    public float spawnTime = 7;

    bool generated = true;
    private void Start()
    {
        
    }
    void Update()
    {
     if (generated == true)
        {
            StartCoroutine("enemySpawn");
            generated = false;
        }
    }


    IEnumerator enemySpawn()
    {
        Debug.Log(spawnTime);

        Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(spawnTime);

        if (spawnTime > 0.9)
        {
            spawnTime -= 0.7f ;
        }
        generated = true;
    }
}
