using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    Vector3 start;
    Vector3 destiny;

    public TurretController turretCl;
   // public EnemyController enemyCl;

    public float bulletSpeed = 10f;
    public int bulletDmg = 2;
    
    void Start()
    {
        turretCl = transform.parent.GetComponent<TurretController>();
        //enemyCl = transform.parent.GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (turretCl.target.position == null)
        {
            Destroy (gameObject);
        }
        shootTravel();
    }
    void shootTravel ()
    {
        transform.position = Vector3.MoveTowards(transform.position, turretCl.target.position, bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) 
        {

            other.gameObject.GetComponent<EnemyController>().EnemyHpLost(bulletDmg);


            Destroy(gameObject);
        }
    }
}