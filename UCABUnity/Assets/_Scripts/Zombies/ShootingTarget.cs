using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTarget : MonoBehaviour
{
    public virtual void GetShot(GunData gData)
    {
        Debug.Log("Bullet Hit");
    }
}
