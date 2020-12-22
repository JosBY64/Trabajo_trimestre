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
    }
}


