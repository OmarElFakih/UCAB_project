using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombies : MonoBehaviour
{
    public GameObject blood;
    public GameObject muerte;
    public GameObject vida;
    [SerializeField] private float MaxHealth = 1;
    [SerializeField] private float currentHealth = 0;
    public float damage;

    /*public Jugador player;
    public float amount = 0;*/

    /* void OnCollisionEnter2D(Collision2D col)
     {
         if (col.gameObject.tag.Equals("Bullet"))
         {      
             Instantiate(blood, transform.position, Quaternion.identity);


             Destroy(col.gameObject);
             Destroy(gameObject);
             DatosGuardados.puntajeactual += 10;
             //player.Damage(amount);
         }
     }*/



    // En Caso de Impactar

    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Jugador":
                SpawnControl.spawnAllowed = false;
                vida.SetActive(false);   //Aquí deveria desactivar el sprite del corazon pero no hace nada
                Destroy(col.gameObject);
                muerte.SetActive(true); //Aqui deveria mostrar el mensaje de muerte después de destruir al jugador
                break;                  //pero no hace nada, deja todo igual

            case "Bullet":
                Instantiate(blood, transform.position, Quaternion.identity);
                Destroy(col.gameObject);
                Destroy(gameObject);
                DatosGuardados.puntajeactual += 10;
                break;
        }
    }

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
