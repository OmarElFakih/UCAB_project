using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControldeJuego : MonoBehaviour
{

    public static ControldeJuego instance;

    public static bool GamePaused = false;

    public GameObject ControldeJuegoUI;

    private DatosGuardados ControldePuntaje;


      void Awake()
      {

        instance = this;
        /*  if (instance == null)
          {
              instance = this;
              DontDestroyOnLoad(this.gameObject);
          }
          else
          {
              if (instance != this)
                  Destroy(this.gameObject);
          }*/
      } 



    void Start()
    {
        ControldePuntaje = FindObjectOfType<DatosGuardados>();
    }

    public void borrarPuntaje()
    {
        PlayerPrefs.DeleteKey("HighScore");
        ControldePuntaje.puntajeMaximo = 0;
    }



    // Update is called once per frame
    void Update()
    {      
    }



    public void Pausar ()
    {
        if (GamePaused)
        {
            ControldeJuegoUI.SetActive(false);
            Time.timeScale = 1f;
            GamePaused = false;
        }
        else
        {
            ControldeJuegoUI.SetActive(true);
            Time.timeScale = 0f;
            GamePaused = true;
        }
        
    }


    [SerializeField]
    private int escena;
    public void CargarEscena(int escena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(escena);
    }



}
