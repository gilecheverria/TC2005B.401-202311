/*
Simple script to follow a target when it enters a trigger for its vision cone

Gilberto Echeverria
2023-04-12
*/

using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] bool chase = false;

    NavMeshAgent agent;
     
    Vector3 origin;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
		agent.updateUpAxis = false;
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (chase) {
            agent.SetDestination(target.position);
        } else {
            agent.SetDestination(origin);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        chase = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        chase = false;
    }
}
