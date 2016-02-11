using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {

    GameObject prefab;

	void Start () {
        prefab = Resources.Load("Projectile") as GameObject;
        print("projectile Start");
	}
	
	void Update () {
        if (Input.GetKeyDown("e")) {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + new Vector3(0,1,0);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 75;
            print("shot");
        }
	}
}
 //+ Camera.main.transform.forward
