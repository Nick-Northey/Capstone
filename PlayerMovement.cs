using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1f;

    public Rigidbody2D Rigidbody;
    public Animator animator;

    Vector2 movement;

    void Update() // User input
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() // Player Movement
    {
        Rigidbody.MovePosition(Rigidbody.position + movement * Speed * Time.fixedDeltaTime);
    }
}
