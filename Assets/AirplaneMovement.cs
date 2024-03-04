using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    public float force;

    public Rigidbody rb;

    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force);

        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * force);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * force);
        }
    }
    




}

