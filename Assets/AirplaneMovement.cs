using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    public float enginePowerThrust, liftBooster, drag, angularDrag;

    public Rigidbody rb;

    void FixedUpdate()
    {
        // 1. เพิ่มแรงขับเคลื่อน

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePowerThrust);
        }

        // 2. แรงยก

        Vector3 lift = Vector3.Project(rb.velocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooster);

        // 3. แรงต้าน

        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;

        // 4. ควบคุม

        // 4.1 ซ้าย/ขวา

        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1);

        // 4.2 ขึ้น/ลง

        rb.AddTorque(Input.GetAxis("Vertical") * transform.right);
    }
        
    
    
    
}

