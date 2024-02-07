using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    private int items = 0;
    [SerializeField] private Text itemText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("items"))
        {
            Destroy(collision.gameObject);
            items++;
            Debug.Log("items" +  items);
            itemText.text = "item"+ items;
        }
    }
}
