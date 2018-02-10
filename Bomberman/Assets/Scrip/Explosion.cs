using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

   public void Desactivar_edificio(GameObject edificio)
    {
        edificio.SetActive(false);
    }
}
