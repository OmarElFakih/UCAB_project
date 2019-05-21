using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour //creado para la primera entrega
{
    /*
    deben crear una referencia a una variable tipo Personaje
    y copiar los datos de esa variable en las referencias correspondientes
    (el PlayerSprite en el Sprite Renderer por ejemplo)
    esta referencia se encuentra en la instancia de ControlDeJuego
    la cual por ser un singleton pueden acceder por medio de
    ControlDeJuego.CJ.seleccionado
    */


    public Personaje arma;
    private float _nextFire = 0;
    private bool _reloading = false;
    [SerializeField] private int _currentBullets = 0;

    [SerializeField] private float _maxHealth = 3;
    [SerializeField] private float _currentHealth = 0;

    // Start is called before the first frame update
    void Start()
    {
        _currentBullets = arma.clipSize;
        _currentHealth = _maxHealth;
        
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
                _nextFire = Time.time + arma.fireRate;
                _currentBullets -= 1;
                if (_currentBullets == 0)
                    StartCoroutine(reload());
            }
        }

    }


    void DescktopShoot()
    {
        if (Input.GetMouseButtonUp(0) && CanShoot())
        {
            arma.Disparar(transform);
            _nextFire = Time.time + arma.fireRate;
            _currentBullets -= 1;
            if (_currentBullets == 0)
                StartCoroutine(reload());
        }
    }

    public void Damage(float amount)
    {
        _currentHealth -= amount;
        if (_currentHealth <= 0)
            Debug.Log("PlayerDead");

    }


    private bool CanShoot() {
        return (!_reloading && Time.time > _nextFire);
    }


    private IEnumerator reload()
    {
        _reloading = true;
        yield return new WaitForSeconds(arma.reloadTime);
        _currentBullets = arma.clipSize;
        _reloading = false;
    }

}
