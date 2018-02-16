using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo : MonoBehaviour {
    public float speed;
    public GameObject enemigo;
    public Animator ani;
    public Star star;
    
    float otro;
    bool rotar;
    public Movimiento_player movimiento_player;
    // Use this for initialization
    void Start ()
    {
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
            star.rest_life();
            StartCoroutine(Timer());        
        }
        else
        {
            if (collision.gameObject.tag != "suelo")
            {
               rotar = true;
            }
        }              
    }

    void reinicia_jugador()
    {
         movimiento_player.reiniciar_posicion();         
    }
    
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        ani.SetBool("ataque", false);
        ani.SetBool("adelante", true);   
        speed = 3;
    }
}
