using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class attackArea : MonoBehaviour
{
    private int damage = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.GetComponent<health2>()!=null)
       {
            health2 health = collision.GetComponent<health2>();
            health.Damage(damage);
            

       }

       


    }
}
