using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{

    private new SpriteRenderer renderer = null;


    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
