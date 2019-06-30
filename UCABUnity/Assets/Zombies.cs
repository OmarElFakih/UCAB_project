using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombies : MonoBehaviour
{
    public GameObject blood;   //referencia a la animacion de la sangre al matar a un zombie
    public GameObject muerte; //referencia el mensaje de muerte
    public GameObject vida;   //referencia al corazon que muestra la vida
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
        vida = GameObject.Find("vida1");
        //la variable vida toma el valor del sprite vida1 buscando el GameObject del MainGame con nombre "vida1"

        muerte = GameObject.Find("Canvas").transform.Find("mMuerte").gameObject; 
        //La variable muerte toma el valor del panel mMuerte buscando el GameObject del MainGAme con nombre "mMuerte"


        switch (col.gameObject.tag)
        {
            case "Jugador":
                SpawnControl.spawnAllowed = false;
                Destroy(col.gameObject);
                vida.SetActive(false);   //Aquí deveria desactivar el sprite del corazon pero no hace nada
                muerte.SetActive(true); //Aqui deveria mostrar el mensaje de muerte después de destruir al jugador
                break;                  //pero no hace nada, deja todo igual


            case "Bullet":
               
			   Destroy(col.gameObject);
               // if (currentHealth == 0)
			//	{
		        Instantiate(blood, transform.position, Quaternion.identity); //Aqui muestra perfectamente la animacion de la sangre
				Destroy(gameObject);
                DatosGuardados.puntajeactual += 10;
		//	}else {
			//		(currentHealth =currentHealth- 1);
	//	}
	//}
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
