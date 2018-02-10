using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Denotacion : MonoBehaviour {

    public Explosion m_explocion;
    public GameObject efecto;
    public  Rigidbody  dispositivo;
    public bool instalacion;

    public Text text_tiepo;
    public Vector3 posicion;

    GameObject edificio_para_destruir;

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
            edificio_para_destruir = collision.gameObject;
          dispositivo.velocity = Vector3.zero;
            posicion = collision.contacts[0].point;
            instalacion = true;
            detonador = true;
        }
    }

    private void timer()
    {
        tiempo = tiempo - Time.deltaTime;

        text_tiepo.text = ((int)tiempo).ToString();
        if (tiempo <= 0)
        {
            detonador = false;
            GameObject explocion = Instantiate(efecto, posicion, Quaternion.identity);
            m_explocion = explocion.GetComponent<Explosion>();
            m_explocion.Desactivar_edificio(edificio_para_destruir);
            Destroy(explocion, 1.5f);
            Destroy(this.gameObject);

        }
    }
}
