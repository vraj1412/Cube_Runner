using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardSpeed = 10.0f;
    public float Diraction = 20;
    public GameObject GameOverBG;
    public float speed;

    public void Update()
    {
        PlayerMovement();
    }
    

 
    public void PlayerMovement()
    {
# if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float touchDeltaX = touch.deltaPosition.x;

                if (touchDeltaX < 0)
                {
                    rb.AddForce(new Vector3(-Diraction * Time.deltaTime * speed, 0, 0), ForceMode.VelocityChange);
                }
                else if (touchDeltaX > 0)
                {
                    rb.AddForce(new Vector3(Diraction * Time.deltaTime * speed, 0, 0), ForceMode.VelocityChange);
                }
            }
        }
#endif
    
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-Diraction * Time.deltaTime * speed, 0, 0),ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(Diraction * Time.deltaTime * speed, 0, 0),ForceMode.VelocityChange);
        }


        rb.AddForce(new Vector3(0, 0, ForwardSpeed), ForceMode.VelocityChange);



    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {

            GameOverBG.SetActive(true);

        }
    }

}
