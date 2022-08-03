using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
    
{
    float Speed;
    Rigidbody myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
       // myRigidbody.vector2(0, 0) * Speed;
       
    }
}
