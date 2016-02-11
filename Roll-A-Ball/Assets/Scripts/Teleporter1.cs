using UnityEngine;
using System.Collections;

public class Teleporter1 : MonoBehaviour {

    public GameObject Receiver;
    public Rigidbody rb;
    public Camera Main;

    void Awake() {
        Transform receiverTransform = Receiver.transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 destination = Receiver.transform.position;
            //Main.transform.position = new Vector3 (10, 4, 0);
            //Main.transform.Rotate(20, -90, 0);
            other.transform.position = destination;
            rb.velocity = Vector3.zero;
        }
    }
}
