using UnityEngine;
using System.Collections;

public class PickUpMovement : MonoBehaviour {

	public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, (Mathf.Sin(speed * Time.time)));

        //transform.position = Vector3.Lerp(endMarker.position, startMarker.position, fracJourney);
        
    }
}
