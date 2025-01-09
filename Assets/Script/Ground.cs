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
    


    public void Start()
    {
        
        for (int i = 0; i < NumOfGround; i++)
        {
            SpwanGround(i);
        }
    }
    public void Update()
    {
        if (PlayerTransform.position.z  > ZSpwan  - (NumOfGround * GroundLentgh))
        {
            SpwanGround(Random.Range(0, 2));
        }
        
    }

    
    public void SpwanGround(int Index)
    {
        Instantiate(GroundPrefabes[Index], transform.position * ZSpwan,transform.rotation);
        ZSpwan += GroundLentgh;
    }

}
