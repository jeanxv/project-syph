using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class aniattack : MonoBehaviour
    

{
    [SerializeField] private Animation anim;
    [SerializeField] private float attackspeed;
    [SerializeField] private float damage;
    float timeUntilmelee;


    private void Update()
    {
        if (timeUntilmelee <= 0)
        {
            if (Input.GetKeyUp(KeyCode.T)) 
            {
                
            }
        }
    }
}
