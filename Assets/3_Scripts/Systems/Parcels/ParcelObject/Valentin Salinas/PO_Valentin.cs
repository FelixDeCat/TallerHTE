using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PO_Valentin : ParcelObject
{
    [SerializeField] private GameObject esfera;
    [SerializeField] private Animator esferaAnimator;
    

    protected override void OnPlaterExit()
    {
        esferaAnimator.SetInteger("Player", 0);
    }

    protected override void OnPlayerEnter()
    {
        Debug.Log("ENTER");
        esferaAnimator.SetInteger("Player", 1);
    }

    protected override void OnStart()
    {
        
    }

    protected override void OnUpdate()
    {
        
        
    }
}
