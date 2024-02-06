using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int MaxHealth = 10;
    public int currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 100;
    }
    public void Damage (int amaount)
    {
        currentHealth -= 20;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        

       
           


    } 
    // Update is called once per frame
    public void Heal(int amaount)
    {
        currentHealth += amaount;
        if (currentHealth > MaxHealth)
        {
            currentHealth = MaxHealth;
        }
        

    }




}




