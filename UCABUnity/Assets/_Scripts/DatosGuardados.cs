using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;

public class DatosGuardados : MonoBehaviour
{
    private  ControldeJuego Control;

    public Text Score;
    public Text HighScore;
    //
        public static int puntajeactual = 0;
        public  int puntajeMaximo;
    //
    //public float puntos ;

   // public bool scoreInc;

    void Start()
    {
        Score = GetComponent<Text>();
       // puntajeMaximo = PlayerPrefs.GetFloat("HighScore", 0f);
      /*{
            puntajeMaximo = PlayerPrefs.GetFloat("HighScore");
        }*/
    }

    void Update()
    {
        /*if (scoreInc == true)
        {
            //puntajeactual += puntos * Time.deltaTime;
          // addPuntos();
        }*/

        Score.text = "" + Mathf.Round(puntajeactual);
        HighScore.text = "HighScore: " + Mathf.Round(puntajeMaximo);

        if (puntajeactual > puntajeMaximo)
        {
            puntajeMaximo = puntajeactual;
          //  PlayerPrefs.SetFloat("HighScore", puntajeMaximo);
        }

        

    }


   
        
    


}
