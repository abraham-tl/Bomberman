using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_player : MonoBehaviour {

    public GameObject player_1;
    public float speed;
    public float speed_rotation;
    public Animator anim;
    public Vector3 posicion_inicial;
   

	// Use this for initialization
	void Start () {
        posicion_inicial  = player_1.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

       

        if (Input.GetAxis ("Vertical")== 1 || Input.GetAxis("Vertical") == -1)
        {
            anim.SetBool("caminar", true);
            float translation = Input.GetAxis("Vertical") * speed;
            translation *= Time.deltaTime;
            transform.Translate(0, 0, translation);
        }
        else
        {
            anim.SetBool("caminar", false);
        }


        //if (Input.GetAxis("Horizontal") != 0 )
        //{
            if (Input.GetAxis("Horizontal") == 1)
            {
            
            anim.SetBool("derecha", true);
        }
            else
            {
                anim.SetBool("derecha", false);
            }
            if (Input.GetAxis("Horizontal") == -1)
            {
                anim.SetBool("izquierda", true);
            }
            else
            {
                anim.SetBool("izquierda", false);
            }
            float rotation = Input.GetAxis("Horizontal") * speed_rotation;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);

        //}
     
    }

    public void reiniciar_posicion()
    {       
        player_1.transform.position = posicion_inicial;
    }
}
