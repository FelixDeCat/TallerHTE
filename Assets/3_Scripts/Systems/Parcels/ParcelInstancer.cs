using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcelInstancer : MonoBehaviour
{
    [SerializeField] ParcelBase model;

    public int width = 5;
    public int height = 5;
    public int parcelSize = 20;
    public int separation = 1;

    public Queue<ParcelData> parcels = new Queue<ParcelData>();

    private void Start()
    {
        var allParcelas = Resources.LoadAll<ParcelData>("Parcelas/");
        Debug.Log(allParcelas.Length);
        for (int i = 0; i < allParcelas.Length; i++)
        {
            parcels.Enqueue(allParcelas[i]);
        }

        float offsetWidth = ((parcelSize + separation) * width - separation) / 2f;
        float offsetHeight = ((parcelSize + separation) * height - separation) / 2f;

        int xCurrent = 0;
        for (int x = 0; x < width; x++)
        {
            int zCurrent = 0;
            for (int z = 0; z < height; z++)
            {
                ParcelBase parcel;
                try
                {
                    var current = parcels.Dequeue();
                    parcel = GameObject.Instantiate(current.parcelModel);
                }
                catch (System.InvalidOperationException ex)
                {
                    parcel = GameObject.Instantiate(model);
                }
                
                parcel.transform.SetParent(this.transform);
                Vector3 pos = new Vector3(xCurrent - offsetWidth, 0, zCurrent - offsetHeight);
                parcel.transform.position = pos;

                zCurrent = zCurrent + parcelSize + separation;
            }
            zCurrent = 0;
            xCurrent = xCurrent + parcelSize + separation;
        }
    }
}
