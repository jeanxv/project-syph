using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class health2 : MonoBehaviour
{
    [SerializeField] private int health = 30;
    private int MAX_HEALTH = 100;


    // Update is called once per frame
    void Update()
    {
        
    }
     
    public void Damage (int amount)
    {
        if (amount > 0)
        {
            throw new System.ArgumentOutOfRangeException("Can not have negavive damage ");
        }

        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }

    }

    public void Heal(int amount)
    {
        if (amount<0)
        {
            throw new System.ArgumentOutOfRangeException("can not have negavtive healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;
       
        if (health + amount > MAX_HEALTH)
        {
            this.health = MAX_HEALTH;


        }
        else
        {
            this.health += amount;
        }

        
       
       
    }
        private void Die()
        {
            Debug.Log("I am dead!");
            Destroy(gameObject);
        }



} 
