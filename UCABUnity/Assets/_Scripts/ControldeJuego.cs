using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ControldeJuego : MonoBehaviour
{

    public static ControldeJuego instance;

    public static bool GamePaused = false;

    public GameObject ControldeJuegoUI;
  
    private DatosGuardados ControldePuntaje;

    // Inform
    public Text waveLabel;
    public GameObject[] nextWaveLabels;

    public bool gameOver = false;

    private int wave = 1;
    public int Wave
    {
        get { return wave; }
        set
        {
            wave = value;
            if (!gameOver)
            {
                for (int i = 0; i < nextWaveLabels.Length; i++)
                {
                    nextWaveLabels[i].GetComponent<Animator>().SetTrigger("nextWave");
                    nextWaveLabels[i].GetComponent<Animator>().SetTrigger("nextWavet");
                }
            }
            waveLabel.text = "WAVE: " + (wave + 1);
        }
    }


    void Awake()
      {

       // instance = this;
          if (instance == null)
          {
              instance = this;
              //DontDestroyOnLoad(this.gameObject);
          }
          else
          {
              if (instance != this)
                  Destroy(this.gameObject);
          }
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

            Time.timeScale = Time.timeScale == 1 ? 0 : 1;
           // Time.timeScale = 1f;
            GamePaused = false;
        }
        else
        {
            ControldeJuegoUI.SetActive(true);

            Time.timeScale = Time.timeScale == 1 ? 0 : 1;
          //Time.timeScale = 0f;
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


    /*
    public Text healthLabel;
    public GameObject[] healthIndicator;

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            // 1
            if (value < health)
            {
                Camera.main.GetComponent<CameraShake>().Shake();
            }
            // 2
            health = value;
            healthLabel.text = "HEALTH: " + health;
            // 2
            if (health <= 0 && !gameOver)
            {
                gameOver = true;
                GameObject gameOverText = GameObject.FindGameObjectWithTag("GameOver");
                gameOverText.GetComponent<Animator>().SetBool("gameOver", true);
            }
            // 3 
            for (int i = 0; i < healthIndicator.Length; i++)
            {
                if (i < Health)
                {
                    healthIndicator[i].SetActive(true);
                }
                else
                {
                    healthIndicator[i].SetActive(false);
                }
            }
        }
    }
*/

}
