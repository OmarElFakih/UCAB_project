using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


public class ControldeJuego : MonoBehaviour
{

    public static ControldeJuego CJ;//necesario para convertir esta clase en un singleton
   
    private ControlDeCanvas Cc = null;

  

    public DatosGuardados datasave;
    


    //datos visibles para otros objetos en escena
    public Personaje seleccionado; // el jugador tomara este dato cuando comienze el juego
    [SerializeField] private Personaje[] _opciones = null; // posibles opciones




   

    [SerializeField]
    private int _escena;



    private DatosGuardados _controlDePuntaje = new DatosGuardados();
    //traten de seguir las convenciones de nombramiento de programacion 
    //como iniciar las variables privadas con un _ y usar mayusculas para diferenciar las diferentes palabras pero no al inicio



    // Singleton
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




    void Start()
    {
      
    }




    //// Control de Pausa
<<<<<<< HEAD
    
=======

>>>>>>> 6fc89c4f867f1e84ae1f594d74f39528cc62d191
    public void pausa ()
    {
        if (Time.timeScale == 1f) 
        {
            Debug.Log("Pause Game");
            Time.timeScale = 0f;    // Pausa Juego
        }
        else if (Time.timeScale == 0f)
        {
            Debug.Log("Resume Game");
            Time.timeScale = 1f;    //Resume Juego
        }
        
    }


    //// Control de Escena

    public void cargarEscena(int escena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(escena);
    }




    //// Control de Puntaje

    public void addPoints() {

        //agregar puntos
        datasave.puntajeactual = datasave.puntajeactual + 5;
       updateScore();
        //Cc.update score
        //Falta que en el control de canvas, creen la UI con el Puntaje
        

    }

    void updateScore()
    {
        /// Actualiza
        if (datasave.puntajeactual > datasave.puntajeMaximo)
        {
            datasave.puntajeMaximo = datasave.puntajeactual;
            
        }

    }


    public void pruebaSaveScore()
    {
        // Esta Crea un archivo para Guardar o Usar
        FileStream file = new FileStream(Application.persistentDataPath + "/Score.dat", FileMode.OpenOrCreate);
        try
        {

            // Esta permite escribir datos en el archivo 
            BinaryFormatter formatter = new BinaryFormatter();
           // formatter.Serialize(file,);

        }catch(SerializationException e)
        {
            Debug.Log("Error en" + e);
        }

        file.Close();

    }

    public void pruebaLoadScore()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/Score.dat", FileMode.Open);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
          //  formatter.Deserialize(file,);
        }catch(SerializationException e)
        {
            Debug.Log("error en " +e);
        }
        file.Close();
    }

    public void borrarPuntaje()//como la prof no menciono nada acerca de borrar puntajes, no creo que haga falta
    {
        /*PlayerPrefs.DeleteKey("HighScore"); el puntaje se guardara en binario
        ControldePuntaje.puntajeMaximo = 0;*/
    }


    


    // Control Personaje

    public void Seleccionar(int opcion)
    {
        
           
        //seleccionado = opciones[int]
    }

    

       
}


// Notas / Comentarios
// public GameObject ControldeJuegoUI; el UI se manejara estrictamente desde el control de Canvas

//public static bool gamePaused = false;

//ControldePuntaje = FindObjectOfType<DatosGuardados>(); DatosGuardados no esta en un Gameobject 
//FindObjectOfType no servira con el



