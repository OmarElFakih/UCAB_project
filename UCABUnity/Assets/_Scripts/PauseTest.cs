using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTest : MonoBehaviour
{
    public void GamePause(){
        Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
    }
}
