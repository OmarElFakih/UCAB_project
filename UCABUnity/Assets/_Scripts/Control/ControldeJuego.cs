using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControldeJuego : MonoBehaviour
{

    public static ControldeJuego CJ;//necesario para convertir esta clase en un singleton

    public static bool gamePaused = false;
    private ControlDeCanvas Cc = null;

    //datos visibles para otros objetos en escena
    public Personaje seleccionado; // el jugador tomara este dato cuando comienze el juego
    [SerializeField] private Personaje[] _opciones = null; // posibles opciones




   // public GameObject ControldeJuegoUI; el UI se manejara estrictamente desde el control de Canvas

    [SerializeField]
    private int _escena;

    private DatosGuardados _controlDePuntaje = new DatosGuardados();
    //traten de seguir las convenciones de nombramiento de programacion 
    //como iniciar las variables privadas con un _ y usar mayusculas para diferenciar las diferentes palabras pero no al inicio


    //convierte esta clase en un singleton, no tocar
      void Awake()
      {
          if (CJ == null)
          {
              CJ = this;
              DontDestroyOnLoad(this.gameObject);
          }
          else
          {
              if (CJ != this)
                  Destroy(this.gameObject);
          }
      } 
    //no tocar


    void Start()
    {
        //ControldePuntaje = FindObjectOfType<DatosGuardados>(); DatosGuardados no esta en un Gameobject 
    }                                                           //FindObjectOfType no servira con el

    public void borrarPuntaje()//como la prof no menciono nada acerca de borrar puntajes, no creo que haga falta
    {
        /*PlayerPrefs.DeleteKey("HighScore"); el puntaje se guardara en binario
        ControldePuntaje.puntajeMaximo = 0;*/
    }


    public void Pausar ()
    {
        if (gamePaused)
        {
            //ControldeJuegoUI.SetActive(false); El UI se manejara estrictamente desde control de Canvas
            Time.timeScale = 1f;
            gamePaused = false; //no esta mal, pero puedes chequear el valor de Time.timescale para cumplir la labor de este booleano
        }
        else
        {
            //ControldeJuegoUI.SetActive(true);
            Time.timeScale = 0f;
            gamePaused = true;
        }
        
    }

    public void AddPoints() {
        //agregar puntos
        //Cc.update score

    }

    public void Seleccionar(int opciion)
    {
        //seleccionado = opciones[int]
    }

    /*[SerializeField]  por cuestion de orden es mejor declarar todas las variables al inicio de la clase
    private int escena;*/
    public void CargarEscena(int escena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(escena);
    }



}
