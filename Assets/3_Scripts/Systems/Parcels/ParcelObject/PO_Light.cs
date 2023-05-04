using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PO_Light : ParcelObject
{
    public bool TurnOffWorldParcel;
    Light light;
    float initialIntensity;
    protected override void OnPlaterExit() 
    {
        light.intensity = 0;
        if (TurnOffWorldParcel)
        {
            DirectionalLightStatic.TurnOn();
        }
    }
    protected override void OnPlayerEnter()
    {
        light.intensity = initialIntensity;
        if (TurnOffWorldParcel)
        {
            DirectionalLightStatic.ShutDown();
        }
    }
    protected override void OnStart() 
    { 
        light = GetComponent<Light>();
        initialIntensity = light.intensity;
        light.intensity = 0;
    }

    protected override void OnUpdate() { }
}
