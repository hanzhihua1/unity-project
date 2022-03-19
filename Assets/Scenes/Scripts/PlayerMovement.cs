using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float maxSpeed = 15f;
    public float forwardForce = 2000f;
    public float rotationSpeed = 1f;
    public float maxRot = 25f;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!gameOver)
        {
            var v = rb.velocity;

            rb.AddForce(0, 15 * Time.deltaTime, 15 * Time.deltaTime, ForceMode.VelocityChange);

            getPlayerInput();

            var yz_mag = (float)Math.Sqrt(v.y * v.y + v.z * v.z); //Get the magnitude in YZ direction
            if (yz_mag > maxSpeed)
            {
                var v_norm = new Vector3(v.x, v.y / yz_mag * maxSpeed, v.z / yz_mag * maxSpeed); //Create a new vector normalized in YZ
                rb.velocity = v_norm;
            }
        }
    }

    void getPlayerInput()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            if (Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);
                if (touch.position.x < Screen.width / 2)
                {
                    rb.AddForce(-50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                else if (touch.position.x > Screen.width / 2)
                {
                    rb.AddForce(50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }
        else
        {
            if (Input.GetKey("d"))
            {
                rb.AddForce(50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            
        }
    }
}

