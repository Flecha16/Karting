// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class Checkpoints : MonoBehaviour {
    // Sistema de vida para enemigos.
    public float puntajeDeObjeto = 1.0f;
    public puntaje pt;

    private void Start() {
        pt = FindObjectOfType<puntaje>();
    }

    void  OnTriggerEnter (  Collider other   ){
        if (other.tag == "Player")//Si toca el tag "bala". 
        {
            pt.puntos += 1.0f;
            Destroy(other.gameObject);//Destruye la bala.
        }
    }
}