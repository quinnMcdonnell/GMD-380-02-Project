using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
   public static Vector2 inputMovement;
    public static float inputAction;

   private PlayerInput PlayerInput;
   private InputAction MoveAction;
   private InputAction AttackAction;

    private void Awake()
    {
        PlayerInput = GetComponent<PlayerInput>();

        MoveAction = PlayerInput.actions["Move"];
        AttackAction = PlayerInput.actions["Attack"];
    }

    private void Update()
    {
        inputMovement = MoveAction.ReadValue<Vector2>();
        inputAction = AttackAction.ReadValue<float>();
    }

    //Source: https://www.youtube.com/watch?v=RN3yuCvazL4&t=358s
}
