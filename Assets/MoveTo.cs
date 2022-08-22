using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour

{
    Rigidbody2D m_Rigidbody;
    public float r_Speed = 8;
    public float u_Speed = 0;

    //prendre la position actuel du myParticule





    // Start is called before the first frame update
    void Start()
    {
        //Prendre les ressources pour pouvoir en faire quelque chose plus tard
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //généré le déplacement de la particule instancier "myParticule"

        // m_Rigidbody.velocity = transform.right * m_Speed;
        //Utiliser le Addforce
        m_Rigidbody.AddForce(Vector2.right * r_Speed, ForceMode2D.Impulse) ;
        m_Rigidbody.AddForce(Vector2.up * u_Speed, ForceMode2D.Impulse);
    }
  

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
