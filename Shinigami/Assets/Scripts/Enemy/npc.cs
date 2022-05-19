using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    public float dummyHealth;
    public float damage2Dummy;
    public Animator anim;
    public AudioSource impactSFX;
    //public AudioSource damageSFX;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            //HealthBarPanel.SetActive(true);
            dummyHealth -= damage2Dummy / 2;
            //damageSFX.Play();
            //slider.value = dummyHealth;

            if (dummyHealth <= 0)
            {
                anim.SetBool("Destroyed", true);
                impactSFX.Play();

                //deadDummyEffect.Play();
                StartCoroutine(Destruir());
            }
        }
    }
    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
    }
}
