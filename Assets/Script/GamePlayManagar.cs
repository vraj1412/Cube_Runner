using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManagar : MonoBehaviour
{
    public static GamePlayManagar Instance;

    public Vector3 LastGroundPostion;
    public void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
