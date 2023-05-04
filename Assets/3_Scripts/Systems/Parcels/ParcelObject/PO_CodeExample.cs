using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PO_CodeExample : ParcelObject
{
    public Material normal;
    public Material rolling;
    public Renderer render;
    protected override void OnPlaterExit()
    {
        render.material = normal;
        transform.localScale = new Vector3(1,1,1);
    }

    protected override void OnPlayerEnter()
    {
        Debug.Log("ENTER");
        render.material = rolling;
        transform.localScale = new Vector3(2, 2, 2);
    }

    protected override void OnStart()
    {
        
    }

    protected override void OnUpdate()
    {
        
        transform.Rotate(0,5,0);
    }
}
