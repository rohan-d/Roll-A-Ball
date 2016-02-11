using UnityEngine;
using System.Collections;

public class FallDeath : MonoBehaviour {

    public GameObject RespawnPoint;
    public Rigidbody rb;

    void Awake()
    {
        Transform receiverTransform = RespawnPoint.transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 destination = RespawnPoint.transform.position;
            other.transform.position = destination;
            rb.velocity = Vector3.zero;

        }
    }
}
