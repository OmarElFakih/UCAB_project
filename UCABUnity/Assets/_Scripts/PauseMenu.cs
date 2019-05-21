using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButtonUI;
    [SerializeField] private string pauseButton;

    void Update(){
        if(Input.GetButtonDown(pauseButton)){
            if (GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }

        }
        
    }
    
    public void Resume(){
        pauseMenuUI.SetActive(false);
        pauseButtonUI.SetActive(true);
        Time.timeScale = 1; //-> dejaremos la labor de pausar el tiempo al ControlDeJuego, no esta mal, pero prefiero mantgener cierto orden
        GameIsPaused = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        pauseButtonUI.SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
}
