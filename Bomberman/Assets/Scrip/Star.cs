using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Star : MonoBehaviour {
    public GameObject player;
    public Movimiento_player m_player;
    public Text txb_vida;
    public Text txb_bom;
   
    public Animator jugador;
    // Use this for initialization
    void Start () {
		if (Global .star )
        {
            
        }
        else
        {
            Global.life = 3;
            Global.bom = 10;
            Global.star = true;
        }
        update_canvas();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public bool restar_bom()
    {
        if (Global.bom >0)
        {
            Global.bom = Global.bom - 1;
            update_canvas();
            return true;
        }
        else
        {
            return false;
        }
     
    }

    public bool rest_life()
    {
        if (Global .life >0 )
        {
            Global.life = Global.life - 1;
            update_canvas();
            jugador.SetBool("die", true);
            StartCoroutine(Timer());           
            return true;
        }
        else
        {
            return false;
        }
    }

    void update_canvas()
    {
        txb_vida.text = Global.life.ToString();
        txb_bom.text = Global.bom.ToString();
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        jugador.SetBool("die", false);
        m_player.reiniciar_posicion();
    }
}
