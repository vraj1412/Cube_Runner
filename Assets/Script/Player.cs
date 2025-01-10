using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 10.0f;
    public float Diraction = 20;
    public GameObject GameOverBG;

    public void Update()
    {
        PlayerMovement();
    }
    

 
    public void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-Diraction * Time.deltaTime, 0, 0),ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(Diraction * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }
       
        rb.AddForce(new Vector3(0, 0, Speed));
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {

            GameOverBG.SetActive(true);

        }
    }

}
