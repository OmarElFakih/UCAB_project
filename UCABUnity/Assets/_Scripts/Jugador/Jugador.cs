using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Arma arma;
    private float nextFire = 0;
    private bool reloading = false;
    [SerializeField] private int currentBullets = 0;

    [SerializeField] private float maxHealth = 3;
    [SerializeField] private float currentHealth = 0;

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
                if (currentBullets == 0)
                    StartCoroutine(reload());
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
            if (currentBullets == 0)
                StartCoroutine(reload());
        }
    }

    public void Damage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
            Debug.Log("PlayerDead");

    }


    private bool CanShoot() {
        return (!reloading && Time.time > nextFire);

    }


    private IEnumerator reload()
    {
        reloading = true;
        yield return new WaitForSeconds(arma.reloadTime);
        currentBullets = arma.clipSize;
        reloading = false;
    }

}
