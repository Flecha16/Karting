using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class puntaje : MonoBehaviour
{
   public float puntos;

   private TextMeshProUGUI textMesh;

    private void Start() 
    {
        textMesh=GetComponent<TextMeshProUGUI>();
        puntos = 0;
    }

    public void Update() {
        textMesh.text = puntos.ToString("");
        if(puntos == 14){
            SceneManager.LoadScene(3);
        }
    }

}



