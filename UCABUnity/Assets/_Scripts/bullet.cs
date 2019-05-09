using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField] private float speed = 0f;
    public float damage;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

       // transform.position += Vector3.up * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ShootingTarget st = other.GetComponent<ShootingTarget>();

        if (st != null)
            st.GetShot(this);
    }
}
