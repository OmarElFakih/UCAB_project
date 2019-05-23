using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "Personaje De Projectiles")]
public class PersonajeProjectiles : Personaje
{

    public GameObject bulletPrefab;

    public override void Disparar(Transform transform)
    {
        Vector3 bulletRotation = transform.eulerAngles;
        bulletRotation.z -= 90;

        BreakOutBall ball = Instantiate(bulletPrefab, transform.position, Quaternion.Euler(bulletRotation)).GetComponent<BreakOutBall>();
        if (ball != null)
        {
            ball.SetGunData(this.gunData);
        }
    }
}
