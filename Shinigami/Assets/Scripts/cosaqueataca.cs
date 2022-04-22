using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosaqueataca : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Health player; 
    void Start()
    {
        rb.velocity = transform.right * speed;
        player = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.TakeDamage(1f);
        }
    }
}
