using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayManagar : MonoBehaviour
{
    public static GamePlayManagar Instance;
    public Vector3 LastGroundPostion;
   

    public void Awake()
    {
        Instance = this;
    }

 
        
}
