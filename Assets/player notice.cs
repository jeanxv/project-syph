using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{


    public class Player : MonoBehaviour
    {
        public float attackRange = 1f; // Adjust as needed
        public LayerMask enemyLayer; // Set in the inspector to the layer where enemies are

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }
        }

        private void Attack()
        {
            Collider[] hitEnemies = Physics.OverlapBox(transform.position, new Vector3(attackRange, attackRange, attackRange), Quaternion.identity, enemyLayer);

            foreach (Collider enemy in hitEnemies)
            {
                // Assuming enemy script has a Kill method
                enemy.GetComponent<kill>().Kill();
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position, new Vector3(attackRange, attackRange, attackRange));
        }
    }
}

