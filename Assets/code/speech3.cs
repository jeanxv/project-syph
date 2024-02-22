using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPEESH4 : MonoBehaviour
{


public Text displaytext;
public float time = 1f;
private bool isDisplay = false;
private float displaytime = 0f;
private void OnTriggerEnter2D(Collider2D collision)
{


    if (collision.CompareTag("Player")) // Check if the collider belongs to the player
    {
        displaytext.text = "LEAVE ME ALONE";
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
    if (other.CompareTag("Player")) // Check if the collider belongs to the player
    {
        displaytext.gameObject.SetActive(false); // Hide the text when player exits the collider
        isDisplay = false;
        displaytime = 0f;

    }
}

}
