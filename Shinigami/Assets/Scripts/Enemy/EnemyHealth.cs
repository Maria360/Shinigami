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
    PlayerPower playerPower;
    public AudioSource damageSFX;
    public Animator anim;
    private void Start()
    {
        enemy = GetComponent<Enemy>();
        playerPower = FindObjectOfType<PlayerPower>();
        HealthBarPanel.SetActive(false);
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = enemy.healthPoints;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            HealthBarPanel.SetActive(true);
            enemy.healthPoints -= playerPower.damage/2; //Me esta bajando el doble
            damageSFX.Play();
            slider.value = enemy.healthPoints;

            if (enemy.healthPoints <= 0)
            {
                Esperar();
                Destroy(gameObject);
                
            }
        }
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(3);
        anim.SetBool("die", true);


    }
}
