using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;


public class DatosGuardados //esta clase no debe heredar de MonoBehaviour
{   //esta clase solo necesita valores para guardar, no necesita mas interacciones

   // private  ControldeJuego Control;

   // public Text Score; 
   // public Text HighScore;
    //
        public float puntajeactual;
        public float puntajeMaximo;
    //
    //public float puntos ;

   //public bool scoreInc;

   /* void Start()
    {
       // puntajeMaximo = PlayerPrefs.GetFloat("HighScore", 0f);
      /*{
            puntajeMaximo = PlayerPrefs.GetFloat("HighScore");
        }
    }*/

   /* void Update()
    {
        if (scoreInc == true)
        {
            //puntajeactual += puntos * Time.deltaTime;
            addPuntos();
        }

        if (puntajeactual > puntajeMaximo)
        {
            puntajeMaximo = puntajeactual;
            PlayerPrefs.SetFloat("HighScore", puntajeMaximo);
        }

        Score.text = "Score: " + Mathf.Round (puntajeactual);
        HighScore.text = "HighScore: " + Mathf.Round (puntajeMaximo);

    }al no heredar de MonoBehaviour, Update no hara nada */

   

   /* public void addPuntos ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            puntajeactual = puntajeactual + 5  ;
        }
    }este metodo debe ir en ControlDeJuego (sin chequear Inputs)*/

   /* public void onTrigger (Collider2D objecto)
    {
        if (objecto.gameObject.name == "target")
        {
            puntajeactual = puntajeactual + 5;
        }
    } */

}
