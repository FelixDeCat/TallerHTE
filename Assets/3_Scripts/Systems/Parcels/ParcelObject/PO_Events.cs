using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PO_Events : ParcelObject
{
    public UnityEvent UE_OnStart;
    public UnityEvent UE_OnPlayerEnter;
    public UnityEvent UE_OnPlaterExit;
    public UnityEvent UE_OnUpdate;
    protected override void OnStart() { UE_OnStart.Invoke(); }
    protected override void OnPlayerEnter() { UE_OnPlayerEnter.Invoke(); }
    protected override void OnPlaterExit() { UE_OnPlaterExit.Invoke(); }
    protected override void OnUpdate() { UE_OnUpdate.Invoke(); }
}
