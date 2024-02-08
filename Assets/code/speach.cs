using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class TextOnCollision : MonoBehaviour
{
    public Text displayText; // Reference to the UI text element

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider belongs to the player
        {
            displayText.text = "i like pancakes "; // Change the text
            displayText.gameObject.SetActive(true); // Make the text visible
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider belongs to the player
        {
            displayText.gameObject.SetActive(false); // Hide the text when player exits the collider
        }
    }
}




