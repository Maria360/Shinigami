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
    public AudioSource chiquitoSFX;
    public AudioSource grandeSFX;
    public AudioSource winSFX;
    public GameObject winPanel;
    public Animator anim;
    float timer=3f;
    bool canChange;
    private void Start()
    {
        boss = GetComponent<Boss>();
        winPanel.SetActive(false);
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
            if (boss.healthPoints == 150 || boss.healthPoints == 50 ||  boss.healthPoints == 10 )
            {
                chiquitoSFX.Play();
                anim.SetBool("Chiquito", true);
                StartCoroutine(Agrandarse());
                StartCoroutine(Normal());
                Debug.Log("chiquito");
            }
            if (boss.healthPoints <= 0)
            {
                //Esperar();
                winSFX.Play();
                winPanel.SetActive(true);
                FindObjectOfType<Manager>().WinGame();
                StartCoroutine(Esperar());
                //Esto consume mucho recurso :c
                //Destroy(gameObject);


            }
        }
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }
    IEnumerator Agrandarse()
    {
        yield return new WaitForSeconds(10);
        grandeSFX.Play();
        anim.SetBool("Grande", true);
        anim.SetBool("Chiquito", false);
    }
    IEnumerator Normal()
    {
        yield return new WaitForSeconds(10);
        anim.SetBool("Grande", false);
        anim.SetBool("Chiquito", false);
        anim.SetTrigger("Normal");

    }
}
