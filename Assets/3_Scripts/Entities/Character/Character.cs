using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    Rigidbody rig;
    CharView refCharView;
    GroundSensor groundSensor;

    Vector3 move;
    [SerializeField] float movementSpeed = 100;

    [SerializeField] float jumpHeight = 1f;
    [SerializeField] AnimationCurve gravityForce;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        groundSensor = GetComponentInChildren<GroundSensor>();
    }

    public void OnMove(Vector2 _move)
    {
        move.x = _move.x;
        move.z = _move.y;
    }
    public void OnJump()
    {
        if (groundSensor.IsGrounded)
        {
            float jumpVelocity = Mathf.Sqrt(jumpHeight * -2.1f * Physics.gravity.y);
            rig.velocity = new Vector3(rig.velocity.x, jumpVelocity, rig.velocity.z);
            rig.AddForce(Vector3.up * Physics.gravity.y, ForceMode.Acceleration);
        }
    }
    public void OnPrimary()
    {
        
    }
    public void OnSecondary()
    {

    }
    public void OnInteract()
    {

    }

    Vector3 aux = new Vector3();
    private void FixedUpdate()
    {
        aux = move * Time.deltaTime * movementSpeed;
        aux.y = rig.velocity.y;
        rig.velocity = aux;

        if (!groundSensor.IsGrounded)
        {
            if (Mathf.Abs(rig.velocity.y) < 0.1f)
            {
                rig.AddForce(Vector3.up * -100 , ForceMode.Acceleration);
            }
        }
    }
}
