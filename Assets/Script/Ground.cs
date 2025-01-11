using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class Ground : MonoBehaviour
{
  
   // public Transform PlayerTransform;
    public Transform Obstacal1;
    public Transform Obstacal2;
    public Transform Obstacal4;
    public Transform Obstacal3;


    public bool IsActive= false;

    public GamePlayManagar Ref_GamePlayManagar;

    public void Start()
    {
        Ref_GamePlayManagar = GamePlayManagar.Instance;
       
    }
    

    
   
    public void OnCollisionEnter(Collision collision)
    {
       

        if (collision.gameObject.tag == "Player")
        {
            IsActive = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (IsActive)
        { 
            IsActive=false;
            transform.localPosition = Ref_GamePlayManagar.LastGroundPostion + new Vector3(0,-0.1F,100f);
            Ref_GamePlayManagar.LastGroundPostion = transform.localPosition;



            Obstacal1.localPosition = new Vector3(GetXPostion(), 1, Random.Range(-0.4f , -2.0f));
            Obstacal2.localPosition = new Vector3(GetXPostion(), 1, Random.Range(-2.0f, 0.0f));
            Obstacal3.localPosition = new Vector3(GetXPostion(), 1, Random.Range(0.0f, 0.02f));
            Obstacal4.localPosition = new Vector3(GetXPostion(), 1, Random.Range(0.2f, 0.5f));
        }
    }

    

    public float GetXPostion()
    {
        int x = Random.Range(0, 3);
        if (x == 0)
        {
            return -0.35f;
        }
        else if(x == 1)
        {
            return 0;
        }
        else
        {    
            return 0.35f;
        }

    }

    

}
