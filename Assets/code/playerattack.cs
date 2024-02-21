using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playerattack : MonoBehaviour

{
    private GameObject attackArea = default;
    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 1f;
    private BoxCollider box;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject; 
        box = GetComponent<BoxCollider>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space pressed");
            box.enabled = !box.enabled;
            
        }
        if (attacking)
        {
            timer += Time.deltaTime;
             
            if (timer >=timeToAttack)
            {
                timer = 1;

                attacking = false;
                
            }
            
        }
    }

    private void Attack ()
    {
        attacking = true;

        attackArea.SetActive(attacking);
    }
}
