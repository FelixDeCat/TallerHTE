using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] float radius = 0.1f;
    bool isGrounded = false;
    public bool IsGrounded { get { return isGrounded; } }
    void Update()
    {
        isGrounded = Physics.OverlapSphere(this.transform.position, radius, mask).Length > 0;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
