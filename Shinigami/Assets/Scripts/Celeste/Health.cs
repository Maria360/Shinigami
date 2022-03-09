using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    //Enemy enemy;
    public float playerHealth;
    public GameObject HealthBarPanel;
    Slider slider;
    public ParticleSystem impactEffect;


    private void Start()
    {
        //enemy = GetComponent<Enemy>();
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = playerHealth;

    }
    public void TakeDamage(float damage)
    {
        playerHealth -= damage;
        slider.value = playerHealth;
        if (playerHealth <= 0)
        {
            gameObject.SetActive(false);//temporal
        }


    }
}
