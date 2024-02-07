using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.AI;

public class ActivateNavMeshAgent : MonoBehaviour
{
    public Transform Player; // Reference to the player GameObject
    public float activationDistance = 5f; // Distance at which the NavMeshAgent should activate

    private NavMeshAgent navMeshAgent;
    private bool activated = false;

    void Start()
    {
        // Get the NavMeshAgent component
        navMeshAgent = GetComponent<NavMeshAgent>();

        // Disable the NavMeshAgent initially
        navMeshAgent.enabled = false;
    }

    void Update()
    {
        // Check if the player is within activationDistance
        if (!activated && Vector3.Distance(transform.position, Player.position) <= activationDistance)
        {
            // Activate the NavMeshAgent
            navMeshAgent.enabled = true;
            activated = true;
        }
        else if (activated && Vector3.Distance(transform.position, Player.position) > activationDistance)
        {
            // Deactivate the NavMeshAgent
            navMeshAgent.enabled = false;
            activated = false;
        }
    }
}

