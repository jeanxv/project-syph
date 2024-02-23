using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pppp : MonoBehaviour
{
     [SerializeField] private float attackSpeed;
    [SerializeField] private Animator anim;

    [SerializeField] private int damage;

    float timeUnityMelee;
    private void Update()
    {
        if (timeUnityMelee <= 3f)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                anim.SetTrigger("ATTACK");
                timeUnityMelee = attackSpeed;
            }
            else
            {
                timeUnityMelee -= Time.deltaTime;
            }
        }   
     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            other.GetComponent<health2>().Damage(damage);
            Debug.Log("enemy");

        }
    }

} 

