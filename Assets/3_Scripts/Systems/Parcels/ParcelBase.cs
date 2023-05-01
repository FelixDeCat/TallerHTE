using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class ParcelBase : MonoBehaviour
{
    HashSet<IActivable> activables = new HashSet<IActivable>();
    bool isActive;
    #region Properties
    public bool IsActive { get { return isActive; } }
    #endregion
    #region Input
    private void Awake()
    {
        activables =
            GetComponentsInChildren<IActivable>()
            .ToHashSet();

        OnAwake();
    }
    private void OnTriggerEnter(Collider other)
    {
        isActive = true;
        OnActivate();
    }
    private void OnTriggerExit(Collider other)
    {
        isActive = false;
        OnDeactivate();
    }
    void Update()
    {
        if (isActive)
        {
            OnUpdate();
        }
    }
    #endregion
    #region Output
    protected abstract void OnAwake();
    protected abstract void OnUpdate();
    protected abstract void OnActivate();
    protected abstract void OnDeactivate();
    #endregion
}
