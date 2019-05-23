using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "Personaje Raycast")]
public class PersonajeRaycast : Personaje
{


    public override void Disparar(Transform transform)
    {
        Vector3 _dir = AngularTweeks.DirectionOffset(playerForwardSide);
        _dir = transform.TransformDirection(_dir);
        Ray _origin = new Ray(transform.position, _dir);
        RaycastHit _hitInfo;
        Debug.DrawRay(transform.position,_dir, Color.green, Mathf.Infinity);

        if (Physics.Raycast(_origin, out _hitInfo, 1000f))
        {
            Debug.Log("Hit");
            ShootingTarget _st = _hitInfo.transform.GetComponent<ShootingTarget>();
            if (_st != null)
            {
                _st.GetShot(gunData);
                Vector3 bounceDir = Vector3.Reflect(_dir, _hitInfo.normal);

                RaycastBounce(gunData.bounces - 1,_hitInfo.point, bounceDir);
            }
        }
    }

    private void RaycastBounce(int bounces, Vector3 origin, Vector3 dir)
    {
        if (bounces == 0)
        {
            return;
        }

        Vector2 _dir = AngularTweeks.DirectionOffset(playerForwardSide);
        Ray _rayOrigin = new Ray(origin, _dir);
        RaycastHit _hitInfo;

        Debug.DrawRay(origin, _dir,Color.green,Mathf.Infinity);
        if (Physics.Raycast(_rayOrigin, out _hitInfo, 1000f))
        {
            Debug.Log("hit");
            ShootingTarget _st = _hitInfo.transform.GetComponent<ShootingTarget>();
            if (_st != null)
            {
                _st.GetShot(gunData);
                Vector3 bounceDir = Vector3.Reflect(_dir, _hitInfo.normal);

                RaycastBounce(gunData.bounces - 1,_hitInfo.point, bounceDir);
            }
        }



    }

}
