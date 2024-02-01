using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twiddle : MonoBehaviour
{
    public float attackRange = 2f;
    public LayerMask targetLayer;
    public KeyCode keyCode = KeyCode.E;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, attackRange, targetLayer))
            {
                Health health = hit.collider.GetComponent<Health>();
                if (health != null)
                {
                    health.Damage(damage);
                }
            }
        }
    }
}
