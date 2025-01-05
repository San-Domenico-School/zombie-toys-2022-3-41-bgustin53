using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float speed;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        speed = agent.speed;
    }

    // Update is called once per frame
    void Update()
    {
        SetDestination();
    }

    private void SetDestination()
    {
        agent.SetDestination(target.position);
    }
        
}
