using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossHealth : MonoBehaviour
{
    Boss boss;
    [SerializeField] float damage2Enemy;
    public GameObject HealthBarPanel;
    Slider slider;
    PlayerPower playerPower;
    //public AudioSource damageSFX;
    //public Animator anim;
    private void Start()
    {
        boss = GetComponent<Boss>();
        playerPower = FindObjectOfType<PlayerPower>();
        //HealthBarPanel.SetActive(false);
        HealthBarPanel.SetActive(true);
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = boss.healthPoints;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            //HealthBarPanel.SetActive(true);
            boss.healthPoints -= playerPower.damage / 2; //Me esta bajando el doble
            //damageSFX.Play();
            slider.value = boss.healthPoints;

            if (boss.healthPoints <= 0)
            {
                Esperar();
                Destroy(gameObject);

            }
        }
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(3);
        //anim.SetBool("die", true);


    }
}
