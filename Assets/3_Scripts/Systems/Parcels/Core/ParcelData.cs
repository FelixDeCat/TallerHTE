using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ParcelData", menuName = "Parcels/ParcelData")]
public class ParcelData : ScriptableObject
{
    public string parcelName;
    public ParcelBase parcelModel;
}
