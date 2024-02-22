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
    

    // Start is called before the first frame update
    void Start()
    {
        attackArea=GetComponent<GameObject>();
        attackArea = transform.GetChild(0).gameObject; 
        

       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");


        if (Input.GetKeyDown(KeyCode.R))
        {
            Attack
            Debug.Log("attack");
            attacking = true;
            
        }
       
    }

    private void Attack ()
    {
        attacking = true;

        attackArea.SetActive(attacking);
    }
}
