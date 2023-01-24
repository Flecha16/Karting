// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {
    // Sistema de vida para enemigos.
    public float puntajeDeObjeto = 1;
    public puntaje pt;

    private void Start() {
        pt = FindObjectOfType<puntaje>();
    }

    void  OnTriggerEnter (  Collider other   ){
        if (other.tag == "Player")//Si toca el tag "Player". 
        {
            pt.puntos += puntajeDeObjeto;
            Destroy(this.gameObject);//Destruye la bala.
        }
    }
}