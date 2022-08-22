using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Music : MonoBehaviour
{
    // nomer une datecollision
    public float waitime = Mathf.Infinity;
    public float dateCollision;
    public AudioClip hajimemashite_bass;
    
    // Start is called before the first frame update
    void Start()
    {
        
        float waitime = Mathf.Infinity;
    GetComponent<AudioSource>().playOnAwake = false;
    GetComponent<AudioSource>().clip = hajimemashite_bass;

        

    }
    void OnTriggerEnter2D()
    {
        GetComponent<AudioSource>().volume += 0.03f ;
        if (GetComponent<AudioSource>().isPlaying)
        {
            dateCollision += dateCollision +1;
            return;

        }
            GetComponent<AudioSource>().Play();
       // si pas de trigger actif pas de music



    }
    // Update is called once per frame
    void Update()
    {
       // check derniere colision +delta => stopmusique
       if (dateCollision < waitime) {
            GetComponent<AudioSource>().Stop();
        }
       
        GetComponent<AudioSource>().volume -= 0.01f;
    }
}
