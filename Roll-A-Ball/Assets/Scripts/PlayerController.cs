using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText, winText;
    public int totalPUs;

    private Rigidbody rb;
    private bool dblJump = true, grounded = true;
    private int count;

    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
         rb.AddForce(movement * speed);

        Jump();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void Jump() {
        if (!grounded && dblJump == true && Input.GetKeyDown("space")) {
            rb.velocity = new Vector3(0, 10, 0);
            dblJump = false;
        }
        else if (grounded == true && Input.GetKeyDown("space")) {
            rb.velocity = new Vector3(0, 7, 0);
            grounded = false;
        }
    }

    void SetCountText() {
        countText.text = totalPUs + " / " + count.ToString();
        if(count >= totalPUs) {
            winText.text = "You Won!";
        }
    }

    void OnCollisionEnter(Collision hit) {
        grounded = true;
        dblJump = true;
    }
}