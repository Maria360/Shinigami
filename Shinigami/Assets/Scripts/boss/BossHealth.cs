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
    float timer=3f;
    bool canChange;
    private void Start()
    {
        boss = GetComponent<Boss>();
        playerPower = FindObjectOfType<PlayerPower>();
        //HealthBarPanel.SetActive(false);
        HealthBarPanel.SetActive(true);
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = boss.healthPoints;

    }
    private void Update()
    {
        if (canChange)
        {
            Debug.Log("entro a change entro");

            timer += Time.deltaTime;
            if (timer >= 0f)
            {
                this.transform.localScale -= new Vector3(2, 2, 0);

                Debug.Log("entro al tiempo 0 entro");
                canChange = false;
                if (!canChange)
                {
                    this.transform.localScale += new Vector3(2, 2, 0);
                }
                timer = 3f;
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            //HealthBarPanel.SetActive(true);
            boss.healthPoints -= playerPower.damage / 2; //Me esta bajando el doble
            //damageSFX.Play();
            slider.value = boss.healthPoints;
            if (boss.healthPoints == 50|| boss.healthPoints == 25|| boss.healthPoints == 10)
            {
                canChange = true;
                Debug.Log("chiquito");
            }
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
