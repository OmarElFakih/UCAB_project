using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Personaje : ScriptableObject
{
    public GunData gunData;

    public Sprite playerSprite;
    public ForwardSide playerForwardSide;

    public Sprite gunSprite;
    public int clipSize;
    public float reloadTime;
    public float fireRate;

    public abstract void Disparar(Transform transform);
  

}

