using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



    public class ActiveObjects : MonoBehaviour
    {

        public GameObject trigger;

        void Start()
        {
           gameObject.GetComponent<NavMeshAgent>().enabled = false;
        }

        void OnTriggerEnter2D(UnityEngine.Collider2D collision)
        {
            if (collision.gameObject.CompareTag("enemy"))
            {
              gameObject.GetComponent<NavMeshAgent>().enabled = true;
            }


        }



    }
