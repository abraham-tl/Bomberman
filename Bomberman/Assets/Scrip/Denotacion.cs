using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Denotacion : MonoBehaviour {

    public  Rigidbody  dispositivo;
	// Use this for initialization
	void Start () {
        dispositivo = GetComponent<Rigidbody>();
	}
	
	

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "edificio" )
        {
            print("Hola");
            dispositivo.velocity = Vector3.zero;
        }
    }
}
