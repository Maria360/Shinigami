using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] float damage2Enemy;
    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            enemy.healthPoints -= damage2Enemy;
            if(enemy.healthPoints <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
