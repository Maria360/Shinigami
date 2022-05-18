using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thorns : MonoBehaviour
{
    public GameObject Player;
    Health health;
    public float damage;
    public float knockbackstrenght;

    private void Start()
    {
        health = Player.GetComponent<Health>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            health.TakeDamage(damage);
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector3 direction = collision.transform.position - transform.position;
                rb.AddForce(direction.normalized * knockbackstrenght, ForceMode2D.Impulse);
            }
        }
    }
    
}
