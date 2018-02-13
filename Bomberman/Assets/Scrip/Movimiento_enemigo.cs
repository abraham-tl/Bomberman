using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo : MonoBehaviour {
    public float speed;
    public GameObject enemigo;
    public Animator ani;
    bool aux;

	// Use this for initialization
	void Start () {
        aux = true;
	}
	
	// Update is called once per frame
	void Update () {
       
        for (int i = 0;i <= 10;i++ )
        {
            //transform.Translate(0, 0, speed *Time .deltaTime );
        }
        ani.SetBool("adelante", false);
	}
}
