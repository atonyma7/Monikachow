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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "player-stand-1") {
            Debug.Log(collision.name);
            rb.velocity = Vector2.zero;
        }
    }
}
