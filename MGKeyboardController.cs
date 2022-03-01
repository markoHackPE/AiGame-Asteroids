using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGKeyboardController : MGAsteroidsShipController 
{
    public float accspeed = 3f; 
    public float rotspeed = -100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override float getSteering()
    {
        float steering = Input.GetAxis("Horizontal");
        steering *= rotspeed;
        steering *= Time.deltaTime;
        return steering;
    }

    public override float getAcceleration()
    {
        float acceleration = Input.GetAxis("Vertical");
        acceleration *= accspeed;    
        acceleration *= Time.deltaTime;
        if(acceleration <0)
        {
            return 0f;
        }     
        else
        {
            return acceleration;
        }
    }


    // Update is called once per frame
    void Update()
    {   

    }
}
