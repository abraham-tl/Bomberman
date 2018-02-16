﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
    public GameObject arma;
    public GameObject proyectil;
    public Transform inicio;
    public float force;
    public Star star;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            Dispara();
        }
    }

    void Dispara()
    {
        if (star.restar_bom())
        {
            GameObject bala = Instantiate(proyectil, inicio.position, inicio.rotation);
            bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * force, ForceMode.Impulse);
        }
      
    }
}
