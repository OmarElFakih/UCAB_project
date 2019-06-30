using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Arma arma;
    private float nextFire = 0;
    private bool reloading = false;
    [SerializeField] private int currentBullets = 0;

    [SerializeField] private float maxHealth = 4;
    [SerializeField] private float currentHealth = 0;
    public GameObject recarga;
    public GameObject tresbalas;
    public GameObject dosbalas;
    public GameObject unabala;
    public GameObject mensajeMuerte;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;


    // Start is called before the first frame update
    void Start()
    {
        currentBullets = arma.clipSize;
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        MobileShoot();
        DescktopShoot();
    }


    void MobileShoot() {
        if (Input.touchCount > 0) {
            if (Input.GetTouch(0).phase == TouchPhase.Ended && CanShoot())
            {
                arma.Disparar(transform);
                nextFire = Time.time + arma.fireRate;
                currentBullets -= 1;

                if (currentBullets == 1)
                {
                    unabala.SetActive(true);
                    tresbalas.SetActive(false);
                    dosbalas.SetActive(false);
                }

                if (currentBullets == 2)
                {
                    dosbalas.SetActive(true);
                    tresbalas.SetActive(false);
                    unabala.SetActive(false);
                }


                if (currentBullets == 0)
                {
                    //recarga.SetActive(true);
                    tresbalas.SetActive(true);
                    dosbalas.SetActive(false);
                    unabala.SetActive(false);
                    StartCoroutine(reload());
                }

            }
        }

    }


    void DescktopShoot()
    {
        if (Input.GetMouseButtonUp(0) && CanShoot())
        {
            arma.Disparar(transform);
            nextFire = Time.time + arma.fireRate;
            currentBullets -= 1;

            if (currentBullets == 1)
            {
                unabala.SetActive(true);
                tresbalas.SetActive(false);
                dosbalas.SetActive(false);
            }

            if (currentBullets == 2)
            {
                dosbalas.SetActive(true);
                tresbalas.SetActive(false);
                unabala.SetActive(false);
            }


            if (currentBullets == 0)
            {
                //recarga.SetActive(true);
                tresbalas.SetActive(true);
                dosbalas.SetActive(false);
                unabala.SetActive(false);
                StartCoroutine(reload());
            }

 
        }
    }

    public void Damage(float amount)
    {
        amount = 1;
        currentHealth -= 1;

        if (currentHealth < 4)
        {
            vida3.SetActive(false);
        }

        if (currentHealth < 2)
        {
            vida2.SetActive(false);
        }

        if (currentHealth < 1)
        {
            vida1.SetActive(false);
        }


        if (currentHealth <= 0)
        {
            Debug.Log("PlayerDead");
            mensajeMuerte.SetActive(true);
            Time.timeScale = 0;
        }

    }


    private bool CanShoot() {
        return (!reloading && Time.time > nextFire);

    }


    private IEnumerator reload()
    {
        reloading = true;
        recarga.SetActive(reloading);
        yield return new WaitForSeconds(arma.reloadTime);
        currentBullets = arma.clipSize;
        reloading = false;
        recarga.SetActive(reloading);
    }

}
