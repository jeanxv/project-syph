using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{

    [SerializeField]Transform target;
    [SerializeField]
    private float _playerAwarenessDistance;


    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        Player = GameObject.Find("Player");
    }





    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

        gameObject.GetComponent<NavMeshAgent>().enabled = false;
        if ((player.transform.position - this.transform.position).sqrMagnitude < 3 * 3) ;
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }
    }
}
