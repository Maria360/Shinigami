using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thorns : MonoBehaviour
{
    public GameObject Player;
    Health health;
    public float damage;
    private void Start()
    {
        health = Player.GetComponent<Health>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            health.TakeDamage(damage);
        }
    }
    
}
