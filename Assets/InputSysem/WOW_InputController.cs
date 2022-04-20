using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class WOW_InputController : MonoBehaviour
{
    [Header("Character Input Values")]
    public Vector2 move;
    public Vector2 look;
    public bool jump;
    public bool sprint;

    [Header("Movement Settings")]
    public bool analogMovement;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = true;
    public bool cursorInputForLook = true;


    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    public void OnLook(InputValue value)
    {
        if (cursorInputForLook)
        {
            LookInput(value.Get<Vector2>());
        }
    }

    public void OnJump(InputValue value)
    {
        JumpInput(value.isPressed);
    }

    public void OnWalk(InputValue value)
    {
        WalkInput(value.isPressed);
    }

    public void OnLookAndRotate(InputValue value)
    {
        LookAndRotateInput(value.Get<Vector2>());

    }

    public void OnCursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnCursorUnlock()
    {
        Cursor.lockState = CursorLockMode.None;
    }




    public void MoveInput(Vector2 newMoveDirection)
    {
        move = newMoveDirection;
    }

    public void LookInput(Vector2 newLookDirection)
    {
        look = newLookDirection;
    }

    public void LookAndRotateInput(Vector2 newLookRotateDirection)
    {
        print($"LookAndRotate {newLookRotateDirection}");
    }


    public void JumpInput(bool newJumpState)
    {
        jump = newJumpState;
    }

    public void WalkInput(bool newSprintState)
    {
        sprint = !newSprintState;
    }

}

