using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotita : MonoBehaviour
{
    private GameObject tinyPlayer;
    private Rigidbody playerRb;
    private GameObject pelotita;
    [SerializeField] Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tinyPlayer = GameObject.Find("TinyPlayer");
        playerRb = tinyPlayer.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == tinyPlayer)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ValentinTagOoB"))
        {
            Destroy(gameObject, 0f);
        }
    }
}
