using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    // public void CargarScene(int escena) 
    //[SerializeField]
   // private string escena;

    public void CargarScene()
    {
        //Application.LoadLevel(escena);    
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
