using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float yatay_hız, dikey_hız, varsayılan_hız;
    private float dikey_haraket, yatay_haraket;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        dikey_haraket = Input.GetAxis("Vertical");
        yatay_haraket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3
        (yatay_haraket * 50 * yatay_hız * Time.deltaTime, varsayılan_hız + dikey_haraket * 50 * dikey_hız * Time.deltaTime);

        if (transform.position.x > 1.85f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y);
            transform.position = right_limit;
        }
        if (transform.position.x < -1.82f)
        {
            Vector3 left_limit = new Vector3(-1.82f, transform.position.y);
            transform.position = left_limit;
        }
    }
}
