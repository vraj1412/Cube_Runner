using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 10.0f;
    public float Diraction = 20;

    public void Update()
    {
        PlayerMovement();
    }
    public void FixedUpdate()
    {
        //PlayerMovement();
        
    }
    public void PlayerMovement()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector3(-Diraction, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector3(Diraction, 0, 0));
        }
        if (Input.GetKey(KeyCode.X))
        {
            rb.AddForce(new Vector3(0, 0, -11f));
        }

        rb.AddForce(new Vector3(0, 0, Speed));
    }
}
