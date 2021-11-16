using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 0.5f;
    Vector3 EulerAngleVelocity;

    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        EulerAngleVelocity = new Vector3(0, 100, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           //rb.AddForce(0,0,thrust,ForceMode.Impulse);
            rb.AddRelativeForce(Vector3.forward * thrust,ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
           //rb.AddForce(0,0,thrust,ForceMode.Impulse);
            rb.AddRelativeForce(Vector3.back * thrust,ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion deltaRotation = Quaternion.Euler(EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion deltaRotation = Quaternion.Euler(-EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }
}
