using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sk1_Hit : MonoBehaviour
{
    public Health player;
    public float damage2Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            player.TakeDamage(damage2Player);
        }
    }
    void Start()
    {
        player = FindObjectOfType<Health>();
    }

}
