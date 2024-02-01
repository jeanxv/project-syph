using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackarea : MonoBehaviour
{
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
      if (collider.GetComponent<health>() !=null )
       {
            health Health = collider.GetComponent<health>();
            Health.TakeDamage(damage);

       } 


            
                
    }
}
