using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Rigidbody rigidbody;
    CharView refCharView;
    Light light;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        refCharView.IsRunning(move.magnitude > 0.1f);
        rigidbody.velocity = move * Time.deltaTime * 200;
    }

}
