using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : ScriptableObject
{
    public int clipSize;
    public float reloadTime;
    public float fireRate;

    public virtual void Disparar(Transform transform)
    {
        Debug.Log("recarga abstracta");
    }

    public virtual void Recargar(Transform transform)
    {
        Debug.Log("recarga abstracta");
    }

}
