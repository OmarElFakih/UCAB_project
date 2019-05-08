using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "Arma de Projectiles")]
public class ArmaDeProjectiles : Arma
{

    public GameObject bulletPrefab;

    public override void Disparar(Transform transform)
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
