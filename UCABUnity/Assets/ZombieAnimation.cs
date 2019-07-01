using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimation : MonoBehaviour
{

    public Sprite[] sprites;
    public float framesPerSecond;
    private SpriteRenderer spriteRenderer;
   

    

    // Start is called before the first frame update
    void Start()
    {
       // spriteRenderer = renderer as SpriteRenderer;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
        index = index % sprites.Length;
        spriteRenderer.sprite = sprites[index];
    }
}
