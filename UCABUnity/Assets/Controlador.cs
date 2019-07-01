﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la escena " + nombre);
        Time.timeScale = 1f;
        SceneManager.LoadScene(nombre);
    }

    public void Salid()
    {
        print("Saliendo del juego");
        Application.Quit();
    }
}
