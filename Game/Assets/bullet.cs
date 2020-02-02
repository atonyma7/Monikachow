using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Speed = 5.9f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * Speed;
    }
}
