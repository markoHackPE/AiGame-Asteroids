using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGAsteroidsShips : MonoBehaviour
{
    public MGKeyboardController controller;
    private float thrust = 200.0f;
    public Rigidbody2D rb;
    private float maxSpeed = 100f; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float steering = controller.getSteering();
        float acceleration = controller.getAcceleration();
        
        transform.Rotate(0, 0, -steering);
        rb.AddForce(transform.up * thrust * acceleration);

        rb.Velocity = Math.Clamp(acceleration,0,maxSpeed);
    }
}
