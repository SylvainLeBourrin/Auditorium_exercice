using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceParticule : MonoBehaviour
{
    public GameObject particule;
    public GameObject myParticule;
    public int counter = 0; //créé un compteur pour géré la creation des objet.
    public int rate = 20; // créé un maximum , déclancher pour notre fonction.
    public float myparticulx = 0f;
    public float myparticuly = 0f;
    public float speed = 8f;
    public GameObject right;
    
     
    //public int My_DT = 1; // Declaration pour faire un Delta Time du cycle de vie.
    //public float More_T = 1f;  // Declaration pour faire un Temps suplementaire variable.
    


    //public static void D1estroy(Object obj, float t = 2.0f);

    // faire des particules en continue * fait

    //avoir une cadence paramétrable

    //une popsition aléatoire dans un cercle de rayon aléatoire
    //public Vector3 position; 

    //utilisé la fonction randon.insideUniteCircle 
    //transform.position = Random.insideUnitCircle * 5;

    // Start is called before the first frame update
    void Start()
    {
      



    }

    // Update is called once per frame
    void Update()
    {
        // faire des particules en continue *voir une autre solution avec 2 élément uniquement.
        //  myParticule = Instantiate(particule, new Vector2(0, 0), Quaternion.identity) ;
        //myParticule.transform.position = new Vector2(myparticulx, myparticuly);
     

    
        
            myParticule = Instantiate(particule, new Vector2(myparticulx, myparticuly), Quaternion.identity);
            myParticule.transform.position = Random.insideUnitCircle * 5;
        



        /*
         * Le clone est bon endroit ,à le bon parent , et la bonne trajectoire.
         * ici le parent est bon , mais aucune trajectoire définie!
         * 
         * 
         * 
         *  controle le nombre de particules créés 
         * 
         */

        // appel et creation de la fonction de calcul des particules:
        // la fonction :
        // if (counter % rate == 0){ nianianiania;}
    }


    }

