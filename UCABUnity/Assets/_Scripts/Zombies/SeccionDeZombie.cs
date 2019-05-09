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

    public override void GetShot(bullet bullet)
    {
        parent.Damage(bullet.damage * dmMultiplier);
        Destroy(bullet.gameObject);
    }



}
