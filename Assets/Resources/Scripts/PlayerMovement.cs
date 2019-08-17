using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float runModifier = 1f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    float isRunning = 1f;
    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        isRunning = 1 + runModifier * Input.GetAxisRaw("Run");
        animator.SetFloat("Running", isRunning);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (movement.sqrMagnitude>0.01f)
        {
            animator.SetFloat("OldH", movement.x);
            animator.SetFloat("OldV", movement.y); 
        }
    }

    void FixedUpdate()
    {
        //movement
        if (movement.magnitude > 1)
            movement = movement.normalized;
        rb.MovePosition(rb.position + movement * moveSpeed * isRunning * Time.fixedDeltaTime);
    }
}
