using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Denotacion : MonoBehaviour {

    public  Rigidbody  dispositivo;
    public bool instalacion;

    
    public Vector3 posicion;

    bool detonador;
    float tiempo; 
	// Use this for initialization
	void Start () {
        dispositivo = GetComponent<Rigidbody>();
        instalacion = false;
        detonador = false;
        tiempo = 5;
	}

    private void Update()
    {
  
        if (instalacion)
        {
            transform.position = posicion;
            transform.rotation = Quaternion.identity;
        }
        if (detonador)
        {
            timer();
            print(tiempo);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "edificio" )
        {
            
          dispositivo.velocity = Vector3.zero;
            posicion = collision.contacts[0].point;
            instalacion = true;
            detonador = true;
        }
    }

    private void timer()
    {
        tiempo = tiempo - Time.deltaTime;
        if (tiempo <= 0)
        {
            detonador = false;
        }
    }
}
