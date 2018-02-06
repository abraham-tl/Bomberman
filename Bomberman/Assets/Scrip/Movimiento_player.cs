using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_player : MonoBehaviour {

    public GameObject player_1;
    public float speed;
    public float speed_rotation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speed_rotation;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

    }
}
