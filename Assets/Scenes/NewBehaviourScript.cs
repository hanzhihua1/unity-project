using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float maxSpeed = 25f;
    public float forwardForce = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        var v = rb.velocity;

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 25 * Time.deltaTime, 25 * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -25 * Time.deltaTime, -25 * Time.deltaTime, ForceMode.VelocityChange);
        }

        var yz_mag = (float)Math.Sqrt(v.y * v.y + v.z * v.z); //Get the magnitude in YZ direction
        if (yz_mag > maxSpeed)
        {
            var v_norm = new Vector3(v.x, v.y / yz_mag * maxSpeed, v.z / yz_mag * maxSpeed); //Create a new vector normalized in YZ
            rb.velocity = v_norm;
            Debug.Log("clamp");
        }
    }
}

