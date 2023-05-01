using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharLinker : MonoBehaviour
{
    Character model;
    CharController controller;

    private void Awake()
    {
        model = GetComponent<Character>();
        controller = GetComponent<CharController>();

        controller.Subscribe_Movement(model.OnMove);
        controller.Subscribe_Jump(model.OnJump);
        controller.Subscribe_Primary(model.OnPrimary);
        controller.Subscribe_Secondary(model.OnSecondary);
        controller.Subscribe_Interact(model.OnInteract);
    }
}
