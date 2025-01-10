using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject[]  GroundPrefabes;
    public float ZSpwan = 0;
    public float GroundLentgh = 30;
    public int NumOfGround = 2;
    public Transform PlayerTransform;
    public Transform Obstacal1;
    public Transform Obstacal2;
    
    public bool IsActive= false;

    public GamePlayManagar Ref_GamePlayManagar;

    public void Start()
    {
        Ref_GamePlayManagar = GamePlayManagar.Instance;
        //for (int i = 0; i < NumOfGround; i++)
        //{
        //    SpwanGround(i);
        //}
    }
    public void Update()
    {
        //if (PlayerTransform.position.z  > ZSpwan  - (NumOfGround * GroundLentgh))
        //{
        //    SpwanGround(Random.Range(0, 2));
        //}
        
    }

    
    public void SpwanGround(int Index)
    {
        Instantiate(GroundPrefabes[Index], transform.forward * ZSpwan,transform.rotation);
        ZSpwan += GroundLentgh;
    }

    public void OnCollisionEnter(Collision collision)
    {
       // Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            IsActive =true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (IsActive)
        { 
            IsActive=false;
            transform.localPosition = Ref_GamePlayManagar.LastGroundPostion + new Vector3(0,-0.1F,100f);
            Ref_GamePlayManagar.LastGroundPostion = transform.localPosition;



            Obstacal1.localPosition = new Vector3(GetXPostion(), 1, Random.Range(-0.4f , 0.0f));
            Obstacal2.localPosition = new Vector3(GetXPostion(), 1, Random.Range(0.0f, 0.5f));
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
