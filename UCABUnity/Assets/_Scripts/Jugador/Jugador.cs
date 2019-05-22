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


    public Personaje personaje;
    private float _nextFire = 0;
    private bool _reloading = false;
    [SerializeField] private int _currentBullets = 0;

    [SerializeField] private float _maxHealth = 3;
    [SerializeField] private float _currentHealth = 0;
    private TargetedRotation _rotator = null;


    // Start is called before the first frame update
    void Start()
    {
        _rotator = GetComponent<TargetedRotation>();
        _currentBullets = personaje.clipSize;
        _currentHealth = _maxHealth;
        string childName = transform.Find("Gun").name;
        Debug.Log(childName);
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
                personaje.Disparar(transform);
                _nextFire = Time.time + personaje.fireRate;
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
            personaje.Disparar(transform);
            _nextFire = Time.time + personaje.fireRate;
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
        yield return new WaitForSeconds(personaje.reloadTime);
        _currentBullets = personaje.clipSize;
        _reloading = false;
    }

}
