using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModification : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject tinyPlayer;



    [SerializeField] private GameObject outerPortal;
    [SerializeField] private GameObject innerPortal;



    void Start()
    {
       player = GameObject.Find("FPS core");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.SetActive(false);
            tinyPlayer.SetActive(true);
            outerPortal.SetActive(false);
        }
        else if (other.gameObject == tinyPlayer)
        {
            tinyPlayer.SetActive(false);
            player.SetActive(true);
            innerPortal.SetActive(false);
        }
    }

}
