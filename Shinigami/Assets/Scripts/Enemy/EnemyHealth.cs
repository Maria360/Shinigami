using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] float damage2Enemy;
    public GameObject HealthBarPanel;
    Slider slider;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
        HealthBarPanel.SetActive(false);
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = enemy.healthPoints;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            HealthBarPanel.SetActive(true);
            enemy.healthPoints -= damage2Enemy/2; //Me esta bajando el doble
            slider.value = enemy.healthPoints;

            if (enemy.healthPoints <= 0)
            {
                Destroy(gameObject);
                
            }
        }
    }
}
