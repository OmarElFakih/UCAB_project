using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private float MaxHealth = 1;
    [SerializeField] private float currentHealth = 0; 
    public float damage;


    public void Damage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            ControlDeZombies.CZ.ZombieDied();
            //ControlDejuego.addScore
            gameObject.SetActive(false);
        }
    }

    
}
