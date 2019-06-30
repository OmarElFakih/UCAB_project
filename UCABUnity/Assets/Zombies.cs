using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public GameObject blood;

   void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))

        {
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
           
        }
    }

 
}
