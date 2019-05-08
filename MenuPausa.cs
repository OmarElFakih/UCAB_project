using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPausa : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {
       
       // if (Input.GetKeyDown(KeyCode.Escape))
       if (Input.touchCount > 0)
        {
            if (GamePaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
    }
    // Nota = Es para teclado de pc. No es obligatorio, creo.
    
     public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void Pause ()
    {
 
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    [SerializeField]
    private string escena;
    public void CargarScene(string escena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(escena);
    }



}
