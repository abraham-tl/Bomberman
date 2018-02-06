using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public float duracion;
    public GameObject efecto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision contacto)
    {

        if (contacto.gameObject.name != null)
        {
            print("hola " + gameObject.name);
            GameObject explocion = Instantiate(efecto, contacto.contacts[0].point, Quaternion.identity);
            Destroy(explocion, 1.5f);
            Destroy(this.gameObject);
        }
    }
}
