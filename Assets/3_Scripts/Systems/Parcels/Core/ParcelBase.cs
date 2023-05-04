using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class ParcelBase : MonoBehaviour
{
    public string name_alumno;
    public string name_parcela;
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
        PlayerParcelObject player = other.GetComponent<PlayerParcelObject>();
        if (player)
        {
            ParcelUiDebugger.Debug(name_alumno, name_parcela);
            isActive = true;
            OnActivate();
            foreach (var a in activables)
            {
                a.Activate();
            }
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerParcelObject player = other.GetComponent<PlayerParcelObject>();
        if (player)
        {
            ParcelUiDebugger.Delete();
            isActive = false;
            OnDeactivate();
            foreach (var a in activables)
            {
                a.Deactivate();
            }
        }
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
