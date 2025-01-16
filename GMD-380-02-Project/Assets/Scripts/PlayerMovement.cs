using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 5f;


    private Vector2 movement;
    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Set(InputManager.inputMovement.x, InputManager.inputMovement.y);

        rb.velocity = movement * MovementSpeed;
    }

    //Source: https://www.youtube.com/watch?v=RN3yuCvazL4&t=358s
}
