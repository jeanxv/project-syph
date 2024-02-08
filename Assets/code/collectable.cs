using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour
   
{
    
    public Text displaytext;
    private int items = 0;
    public float time = 3f;
    private bool isDisplay = false;
    private float displaytime = 0f;
    [SerializeField] private Text itemsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("items"))
        {
            Destroy(collision.gameObject);
            items++;
            itemsText.text = "items:"+ items;

     
        
        }

        if (collision.CompareTag("items")) // Check if the collider belongs to the player
        {
            displaytext.text = "i like pancakes "; // Change the text
            displaytext.gameObject.SetActive(true); // Make the text visible
            isDisplay = true;

        }
       
    }
    
        private void Update()
    {
            if (isDisplay)
            {
                displaytime += Time.deltaTime;
                if (displaytime >= time)
                {
                    displaytext.gameObject.SetActive(false);
                    displaytime = 0f;
                    isDisplay = false;
                }
            }
        }
 private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("items")) // Check if the collider belongs to the player
        {
            displaytext.gameObject.SetActive(false); // Hide the text when player exits the collider
            isDisplay = false;
            displaytime = 0f;

        }
    }
    
}
