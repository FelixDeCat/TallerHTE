using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharController : MonoBehaviour
{
    public bool axisRaw = false;
    Action<Vector2> move;
    Action jump;
    Action interact;
    Action primary;
    Action secondary;
    public void Subscribe_Movement(Action<Vector2> _move) => move = _move;
    public void Subscribe_Jump(Action _jump) => jump = _jump;
    public void Subscribe_Interact(Action _interact) => interact = _interact;
    public void Subscribe_Primary(Action _primary) => primary = _primary;
    public void Subscribe_Secondary(Action _secondary) => secondary = _secondary; 

    Vector2 auxMove = new Vector2();
    private void Update()
    {
        auxMove.x = axisRaw ? Input.GetAxisRaw("Horizontal") : Input.GetAxis("Horizontal");
        auxMove.y = axisRaw ? Input.GetAxisRaw("Vertical") : Input.GetAxis("Vertical");
        move.Invoke(auxMove);

        if (Input.GetButtonDown("Jump")) jump.Invoke();
        if (Input.GetButtonDown("Interact")) interact.Invoke();
        if (Input.GetButtonDown("Fire1")) primary.Invoke();
        if (Input.GetButtonDown("Fire2")) secondary.Invoke();
    }
    
    public float Horizontal
    {
        get
        {
            return axisRaw ? Input.GetAxisRaw("Horizontal") : Input.GetAxis("Horizontal");
        }
    }
    public float Vertical
    {
        get
        {
            return axisRaw ? Input.GetAxisRaw("Vertical") : Input.GetAxis("Vertical");
        }
    }
    public bool Jump
    {
        get
        {
            return Input.GetButtonDown("Jump");
        }
    }
    public bool Interact
    {
        get
        {
            return Input.GetButtonDown("Interact");
        }
    }
    public bool PrimaryAttack
    {
        get
        {
            return Input.GetButtonDown("Fire1");
        }
    }
    public bool SecondaryAttack
    {
        get
        {
            return Input.GetButtonDown("Fire2");
        }
    }
}
