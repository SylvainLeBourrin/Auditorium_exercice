using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
         if (coll.gameObject.tag == "Particule")
        {
            Destroy(coll.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
