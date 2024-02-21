using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class SPEESH2 : MonoBehaviour
{

    public Text displaytext;
    public float time = 3f;
    private bool isDisplay = false;
    private float displaytime = 0f;
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("FAMILY")) // Check if the collider belongs to the player
        {
            displaytext.text = "WHY IS..THIS HERE";
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
        if (other.CompareTag("FAMILY")) // Check if the collider belongs to the player
        {
            displaytext.gameObject.SetActive(false); // Hide the text when player exits the collider
            isDisplay = false;
            displaytime = 0f;

        }
    }

}