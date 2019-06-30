using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    public static ZombieControl ZC = null;

    [SerializeField]
    private PolygonCollider2D[] colliders;
    private int currentColliderIndex = 0;


    private Vector3 moveDirection;
    public float moveSpeed;
    public float turnSpeed;
    GameObject target;
    Rigidbody2D rb;
   

    // Start is called before the first frame update
    void Start()
    {
        // Designa target como Jugador
        target = GameObject.Find("Jugador");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(0.5f, 1f);  // Da un rango para la velocidad del movimiento de los zombies

    }

    // Update is called once per frame
    void Update()
    {
        MoveZombie();

    }



    // Moviemiento del Zombie 
    void MoveZombie()
    {

        // Aqui cambia la dirección al que va dirigido el zombie, obviamente siempre ira hacia el Jugador que estará quieto de cualquier forma
        if (target != null)
        {
            moveDirection = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector3(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed, 0);

            float targetAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation =
              Quaternion.Slerp(transform.rotation,
                                Quaternion.Euler(0, 0, targetAngle),
                                turnSpeed * Time.deltaTime);

        } else
        {
            rb.velocity = Vector3.zero;
        }
    }




    // En Caso de Impactar

  /*  void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag) {
            case "Jugador":
                SpawnControl.spawnAllowed = false;
                Destroy(col.gameObject);
                break;

            case "bullet":           
                Destroy(col.gameObject);
                Destroy(gameObject);
                break;
        }
    }
    */


    public void SetColliderForSprite(int spriteNum)
    {
        colliders[currentColliderIndex].enabled = false;
        currentColliderIndex = spriteNum;
        colliders[currentColliderIndex].enabled = true;
    }




}

