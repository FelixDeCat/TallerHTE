using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalLightStatic : MonoBehaviour
{
    Light myLight;
    public static DirectionalLightStatic instance;
    private void Awake()
    {
        instance = this;
        myLight = GetComponent<Light>();
    }

    public static void ShutDown()
    {
        instance.myLight.intensity = 0;
    }
    public static void TurnOn()
    {
        instance.myLight.intensity = 1;
    }
}
