using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackarea : MonoBehaviour
{
    private int damage =30;

    private void OnTriggerEnter2D(Collider2D collider)
    {
      if (collider.GetComponent< health>()!=null)
       {
            health health = collider.GetComponent<health>();

            health.Damge;
            

       } 


            
                
    }
}
