using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlDeCanvas : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu = null;
    private bool pauseIsActive = false;

    

    public void pausar() {
        PauseMenu.SetActive(!pauseIsActive);
        pauseIsActive = !pauseIsActive;
    }
}
