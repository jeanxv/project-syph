using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAttack : MonoBehaviour
{
    public int damageamount = 10; // Amount of damage inflicted on the enemy
    public float attackRange = 2f; // Range of the attack
    public LayerMask enemyLayer; // Layer mask for the enemy

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }

    void Attack()
    {
        // Detect enemies within the attack range
        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, enemyLayer);

        // Damage each enemy
        foreach (Collider enemy in hitEnemies)
        {
            // Assuming enemies have a Health script
            health2 enemyHealth = enemy.GetComponent<health2>();
            if (enemyHealth != null)
            {
                enemyHealth.Damage(damageamount);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw attack range gizmo in editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}



