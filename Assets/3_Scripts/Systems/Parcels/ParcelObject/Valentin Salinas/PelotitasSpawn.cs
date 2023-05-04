using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotitasSpawn : MonoBehaviour
{
    [SerializeField] private GameObject pelotita;

    float time = 2;

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if (time <= 0)
            {
                time = 5;
                Instantiate(pelotita, transform.position, pelotita.transform.rotation); ;
            }
        }

    }
}
