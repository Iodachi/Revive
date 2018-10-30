using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{

    [SerializeField]
    private Transform respawnPoint;

    public float lookRadius = 10f;

    PlayerControl player;
    Transform target;
    NavMeshAgent agent;

    //the colour represented by this enemy, if it is the same as player's colour,
    //the enemy won't attack
    public int enemyColour = 1;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerControl>();
        target = player.transform;
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius && enemyColour != player.colour)
        {
            agent.SetDestination(target.position);

            //Hard coded 3 because that's the distance it is when it's close enough to the player
            if (distance <= 5)
            {
                //Face the target
                FaceTarget();

                //Attack the target
                Attack();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            player.transform.position = respawnPoint.transform.position;
        }
    }

    void Attack()
    {
        player.transform.position = respawnPoint.transform.position;
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.y));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    //Drawing radius that enemy can follow player
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
