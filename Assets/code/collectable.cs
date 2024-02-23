using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class collectable  : MonoBehaviour
   
{
    
    
    private int items = 0;

   
   
    [SerializeField] private Text itemsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("items"))
        {
            Destroy(collision.gameObject);
            items++;
            itemsText.text = "items:"+ items;

     
        
        }

       
       
    }
    
       
    
}
