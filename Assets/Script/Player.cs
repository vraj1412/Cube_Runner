using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 10.0f;
    public float Diraction = 0.02f;

    public void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            rb.AddForce(new Vector3(-Diraction, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(Diraction, 0, 0));
        }

        rb.AddForce(new Vector3(0, 0, Speed));
       
    }
}
