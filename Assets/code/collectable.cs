using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    private int items = 0;
    [SerializeField] private Text item;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("items"))
        {
            Destroy(collision.gameObject);
            items++;
            Debug.Log("items" +  items);
            items.text = "item"+ items;
        }
    }
}
