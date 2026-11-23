
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peperlarx : MonoBehaviour
{
    // High speed ensures the blur effect looks correct
    private float propellerSpeed = 1000.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates the propeller around its Z-axis (forward facing) every frame
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
