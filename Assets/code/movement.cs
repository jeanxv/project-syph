using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    public collectable cl;
    public Camera cam;
    private float timer;

    // Update is called once per frame
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

       if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("spacepressed");
            Vector3 pos = new Vector3(41.16f, -25.01f, -20.0f);
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

            Debug.Log("spacepressed");
            Vector3 pos = new Vector3(0f, 0f, -20.0f);
            Camera.main.fieldOfView = 43f;

        }
       

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

       
    }
   

}
