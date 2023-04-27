using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharView : MonoBehaviour
{
    Animator myAnim;
    private void Awake()
    {
        myAnim = GetComponent<Animator>();
    }
    public void IsRunning(bool val)
    {
        myAnim.SetBool("IsRunning", val);
    }
}
