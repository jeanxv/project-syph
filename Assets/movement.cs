using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("horizontal");
        movement.y = Input.GetAxisRaw("vertical");

        animator.SetFloat("horizontal",movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

    }

     void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

   
}
