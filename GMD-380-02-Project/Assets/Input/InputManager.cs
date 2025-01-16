using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
   public static Vector2 inputMovement;

   private PlayerInput PlayerInput;
   private InputAction MoveAction;

    private void Awake()
    {
        PlayerInput = GetComponent<PlayerInput>();

        MoveAction = PlayerInput.actions["Move"];
    }

    private void Update()
    {
        inputMovement = MoveAction.ReadValue<Vector2>();
    }

    //Source: https://www.youtube.com/watch?v=RN3yuCvazL4&t=358s
}
