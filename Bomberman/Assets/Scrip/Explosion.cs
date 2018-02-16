using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public float radio_explosion;
    public Star star;
   public void Desactivar_edificio()
    {
        star = FindObjectOfType<Star>();
        Collider[] obj_rangos = Physics .OverlapSphere (transform .position ,radio_explosion ); 

        foreach (Collider edificio in obj_rangos)
        {
            if (edificio .tag == "edificio")
            {
                edificio.gameObject.SetActive(false);
            }
            if (edificio.tag == "Player")
            {
               star.rest_life ();
             
            }
            if (edificio.tag == "enemigo")
            {
                edificio.gameObject.SetActive(false);
            }
        }
    }
}
