using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParcelObject : MonoBehaviour, IActivable
{
    public bool isUpdating;
    protected virtual void Awake()
    {
        isUpdating = false;
    }
    protected virtual void Start()
    {
        OnStart();
    }
    protected virtual void Update()
    {
        if (isUpdating) OnUpdate();
    }

    protected abstract void OnStart();
    protected abstract void OnUpdate();
    protected abstract void OnPlayerEnter();
    protected abstract void OnPlaterExit();

    void IActivable.Activate()
    {
        isUpdating = true;
        OnPlayerEnter();
    }

    void IActivable.Deactivate()
    {
        isUpdating = false;
        OnPlaterExit();
    }
}
