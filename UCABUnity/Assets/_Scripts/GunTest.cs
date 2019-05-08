using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTest : MonoBehaviour
{
    public Arma arma;
    float nextfire = 0;


    private void Start()
    {
        StartCoroutine(Wait());   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextfire) {
            arma.Disparar(transform);
           
        }
            
    }

    private IEnumerator Wait() {
        Debug.Log("1a fase");

        yield return new WaitForSeconds(3);

        Debug.Log("2da fase");

    }




}
