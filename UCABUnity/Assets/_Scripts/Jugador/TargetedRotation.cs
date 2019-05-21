using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetedRotation : MonoBehaviour
{
    
    public Transform target;

    public float rotationSpeed;
    public ForwardSide forwardSide;
   

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorToTarget = target.position - transform.position;

        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - AngularTweeks.AngleOffset(this.forwardSide);

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed);
    }

  
}



