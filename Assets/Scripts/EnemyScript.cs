using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{  
    public NavMeshAgent agent;

    public Transform player;
    public GameObject endScreen;

    public LayerMask whatIsGround;
    public LayerMask whatIsPlayer;

    //patroling
    public Transform[] waypoints;
    private int currentWaypoint;
    public float speed;

    //states
    public float sightRange;
    public float attackRange;

    public bool playerInSightRange;
    public bool playerInAttackRange;

    // Start is called before the first frame update
    private void awake()
    {
        player = GameObject.Find("PlayerGameobject").transform;
        agent = GetComponent<NavMeshAgent>();
        
    }

    private void Start()
    {
        currentWaypoint = 0;
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange)
        {
            Patroling();
        }
        if (playerInSightRange && !playerInAttackRange)
        {
            Chasing();
        }
        if (playerInSightRange && playerInAttackRange)
        {
            Attacking();
        }
    }

    private void Patroling()
    {
       if (transform.position != waypoints[currentWaypoint].position)
        {
            agent.SetDestination(waypoints[currentWaypoint].position);
        }
        else
        {
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length;
        }
    }

    

    private void Chasing()
    {
        agent.SetDestination(player.position);
    }

    private void Attacking()
    {
        endScreen.SetActive(true);
    }


}
