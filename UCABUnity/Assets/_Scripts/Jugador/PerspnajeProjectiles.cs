using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "Arma de Projectiles")]
public class PersonajeProjectiles : Personaje
{

    public GameObject bulletPrefab;

    public override void Disparar(Transform transform)
    {
        Vector3 bulletRotation = transform.eulerAngles;
        bulletRotation.z -= 90;

        Instantiate(bulletPrefab, transform.position, Quaternion.Euler(bulletRotation));
    }
}
