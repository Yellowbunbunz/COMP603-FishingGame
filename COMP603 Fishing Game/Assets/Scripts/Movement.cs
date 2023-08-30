using System;
using UnityEngine;

public class testCube : MonoBehaviour
{

    float speed = 10.0f;
    public float jumpPosition = 2.0f;
    public float jumpForce = 50.0f;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    { 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime* speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime *speed);
        }
        if(Input.GetKey(KeyCode.Space) && transform.position.y <= jumpPosition) 
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }
    }
}
