using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlDeCanvas : MonoBehaviour
{//traten de apegarse a los nombres que les di en el diagrama de clases


    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButtonUI;
    public GameObject recarga;
    private string pauseButton;



    void Update()
    {
      
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseButtonUI.SetActive(true);
        Time.timeScale = 1; //-> dejaremos la labor de pausar el tiempo al ControlDeJuego, no esta mal,
        GameIsPaused = false; // pero es mejor mantener cierto orden con respecto a que se encarga de que
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseButtonUI.SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void Pausar()
    {
        if (GameIsPaused)
        {
            pauseMenuUI.SetActive(false);
            pauseButtonUI.SetActive(true);
            Time.timeScale = Time.timeScale == 1 ? 0 : 1;
            // Time.timeScale = 1f;
            GameIsPaused = false;
        }
        else
        {
            pauseMenuUI.SetActive(true);
            pauseButtonUI.SetActive(false);

            Time.timeScale = Time.timeScale == 1 ? 0 : 1;
            //Time.timeScale = 0f;
            GameIsPaused = true;
        }

    }




    

}
