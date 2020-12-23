using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public GameObject destination;

    NavMeshAgent path;

    PlayerController playerCl;

    public int damage;
    public float punchPoints = 5;
     
    void Start()
    {
        path = this.GetComponent<NavMeshAgent>();
        setDestination();
        playerCl = GameObject.Find("PlayerController").GetComponent<PlayerController>();
    }


  private void setDestination()
    {
        if (destination == null)
        {
            destination = GameObject.FindWithTag("EnemyEnd");
            Vector3 targetVector = destination.transform.position;
            path.SetDestination(targetVector);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyEnd"))
        {
            playerCl.LifeSteal(damage);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            
        }
    }
    public void EnemyHpLost(int daño)
    {
        punchPoints -= daño;
        if (punchPoints <= 0)
        {
            playerCl.money += 50;
            Destroy(gameObject);
        }
    }
}


