using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{

    public void Kill()
    {
        Debug.Log("Enemy killed!"); // You can add more actions here, like playing death animation, adding score, etc.
        Destroy(gameObject); // Destroy the enemy GameObject
    }

}
