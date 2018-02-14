using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo : MonoBehaviour {
    public float speed;
    public GameObject enemigo;
    public Animator ani;
    public Animator player;
    Vector3 aux;
    float otro;
    bool rotar;
    // Use this for initialization
    void Start () {
        aux = transform.position;
        rotar = false;
	}
	
	// Update is called once per frame
	void Update () {
        otro = speed * Time.deltaTime;


        if (rotar)
        {
            transform.Rotate(0,180,0);
            rotar = false;
        }
        else
        {
            //ani.SetBool("adelante", false);
            transform.Translate(Vector3.forward * otro);
        }
        
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject .tag == "Player" )
        {
            speed = 0;
            ani.SetBool("adelante", false);
            ani.SetBool("ataque", true);

            player.SetBool("die", true);
        }
        else
        {
            if (collision.gameObject.tag != "suelo")
            {
                print(collision.gameObject.name);
                rotar = true;
            }
        }  
              
    }
}
