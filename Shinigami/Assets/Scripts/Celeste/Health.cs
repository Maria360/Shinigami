using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    Enemy enemy;
    public float playerHealth;
    public GameObject HealthBarPanel;
    Slider slider;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = playerHealth;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy Wepon"))
        {
            playerHealth -= enemy.damage2Player;
            slider.value = playerHealth;

            if (playerHealth <= 0)
            {
                Destroy(gameObject);//temporal
            }
        }
    }
}
