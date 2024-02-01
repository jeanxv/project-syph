using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health2 : MonoBehaviour
{
    [SerializeField]private int health = 30;


    // Update is called once per frame
    void Update()
    {
        
    }
     
    public void Damage (int amaount)
    {
        if (amaount > 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannaoy have negative Damage");
        }

        this.health -= amaount;
    }

    public void Heal(int amaount)
    {
        if (amaount > 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannaoy have negative healing");

        }
        this.health += amaount;
    }
}
