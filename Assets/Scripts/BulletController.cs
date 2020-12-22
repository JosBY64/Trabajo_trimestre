using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    Vector3 start;
    Vector3 destiny;

    public TurretController turretCl;

    public float bulletSpeed = 10f;
    
    void Start()
    {
        turretCl = transform.parent.GetComponent<TurretController>();
    }

    // Update is called once per frame
    void Update()
    {
        shootTravel();
    }
    void shootTravel ()
    {
        transform.position = Vector3.MoveTowards(transform.position, turretCl.target.position, bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) ;
        {
            Destroy(gameObject);
        }
    }
}