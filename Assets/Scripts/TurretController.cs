using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{

    public GameObject enemyMarket;
    public GameObject bulletPrefab;

    private Vector3 turretCoords;

    //private bool checkEnemy = false;
    public string enemyTag = "Enemy";

    private float range = 8f;
    public float fireRate = 1f;
    private float fireCount = 0f;

    public Transform target;
    void Start()
    {
        turretCoords = transform.position;
    }


    void Update()
    {

        updateTarger();

        if (target == null)
        {
            return;
        }

        //Vector3 dir = target.position - transform.position;
       // Quaternion lookRotation = Quaternion.LookRotation(dir);


        if (target != null)
        {
            Vector3 turretTargetVector = target.position;
            Debug.DrawLine(turretTargetVector, turretCoords, Color.green);
            //Debug.Log("LLEGA");

            if (fireCount <= 0F)
            {
                shoot();
                fireCount = 1f / fireRate;
            }
            fireCount -= Time.deltaTime;
        }
   
        
    }

    void updateTarger()
    {
        float shortesDistance = Mathf.Infinity;
        GameObject nearesEnemy = null;

        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        foreach (GameObject enemyMarket in enemies)
        {
            float distanceEnemyMarket = Vector3.Distance(transform.position, enemyMarket.transform.position);
            if (distanceEnemyMarket < shortesDistance)
            {
                shortesDistance = distanceEnemyMarket;
                nearesEnemy = enemyMarket;


            }

            if (nearesEnemy != null && shortesDistance <= range)
            {
                //Debug.Log("distancia " + shortesDistance);
                target = nearesEnemy.transform;

            }
            else
            {
                //Debug.Log("tardet anulado");
                target = null;
            }
        }

      
    }

    void shoot()
    {
        Debug.Log("Disparo");

        Instantiate(bulletPrefab, turretCoords, target.rotation,transform);

        
    }


}



