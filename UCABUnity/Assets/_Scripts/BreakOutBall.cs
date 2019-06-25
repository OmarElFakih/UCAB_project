using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOutBall : MonoBehaviour
{
    [SerializeField] private GunData _gData;
    private Vector3 _orgPosition = Vector3.zero;
    private Rigidbody2D rb;

    public float speed;
    public ForwardSide forwardSide;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        SetVelocity();

        _orgPosition = transform.position;

        Destroy(this.gameObject, 2f);
    }


    private void Update()
    {
        Vector3 moveDirection = transform.position - _orgPosition;


        float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg - AngularTweeks.AngleOffset(forwardSide);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Debug.Log(rb.velocity.magnitude);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        ShootingTarget _sT = other.collider.GetComponent<ShootingTarget>();
        if (_sT != null)
        {
            _sT.GetShot(_gData);
        }

        _orgPosition = other.contacts[0].point;

        if (_gData.bounces == 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _gData.bounces--;
        }

        SetVelocity();
        
    }


    private void SetVelocity() {
        Vector3 velocity = Vector3.up * speed;
        velocity = transform.TransformDirection(velocity);
        rb.velocity = velocity;

    }

    public void SetGunData(GunData data)
    {
        this._gData = data;
    }



}
