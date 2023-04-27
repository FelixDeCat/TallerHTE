using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetResources : MonoBehaviour
{
    public Item[] items;
    private void Start()
    {
        items = Resources.LoadAll<Item>("Items/");
    }
}
