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
    [SerializeField] private Animation anim;
    float timeUntilmelee;
    // Start is called before the first frame update
    void Start()
    {
        attackArea=GetComponent<GameObject>();
        attackArea = transform.GetChild(0).gameObject; 
        

       
    }

    // Update is called once per frame
   private  void Update()
    {
        Debug.Log("update");


        if (Input.GetKeyDown(KeyCode.R))
        {
            
            Debug.Log("attack");
            attacking = true;
            
        }
        if (timeUntilmelee <= 0)
        {
            if (Input.GetKeyUp(KeyCode.T))
            {
                anim.Play();
            }
        }
    }

    private void Attack ()
    {
        attacking = true;

        attackArea.SetActive(attacking);
    }
}
