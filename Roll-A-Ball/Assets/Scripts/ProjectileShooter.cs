using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {

    GameObject prefab;

    void Start () {
        prefab = Resources.Load("Projectile") as GameObject;
	}
	
	void Update () {
        if (Input.GetKeyDown("e")) {
            Shoot();
        }
    }

    void Shoot() {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + new Vector3(0, 1, 0);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 75;
            print("shot");
    }

    void OnTriggerEnter(Collision collision) {
        if (collision.collider.tag == "Cube")
        {
            Destroy(this.gameObject);
        }
    }
}
 //+ Camera.main.transform.forward
