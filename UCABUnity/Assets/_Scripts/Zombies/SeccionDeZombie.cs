using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeccionDeZombie : ShootingTarget
{
    [SerializeField] private float dmMultiplier = 1f;

    private Zombie parent = null;

    private void Start()
    {
        parent = GetComponentInParent<Zombie>();
    }

    public override void GetShot(GunData data)
    {
        parent.Damage(data.damage * dmMultiplier);
       // Destroy(bullet.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Jugador j = other.GetComponent<Jugador>();
        if (j != null)
            j.Damage(parent.damage);
        ControlDeZombies.CZ.ZombieDied();
        parent.gameObject.SetActive(false);
    }



}
