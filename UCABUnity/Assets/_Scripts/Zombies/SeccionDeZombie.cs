using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeccionDeZombie : ShootingTarget
{
    [SerializeField] private float dmMultiplier = 0f;

    private Zombie parent = null;

    private void Start()
    {
        parent = GetComponentInParent<Zombie>();
    }

    public override void GetShot(bullet bullet)
    {
        
    }
}
