using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 100.0f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get Up/Down arrow or W/S input
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward constantly
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Tilt the plane up or down based on arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}