using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canhg : MonoBehaviour
{
    public GameObject gb;
    void Update()
    {
        if (gb == null)
        {
            Debug.Log("gone");
            SceneManager.LoadSceneAsync(2);

        }

    }
}
