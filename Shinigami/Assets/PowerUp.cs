using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public ParticleSystem destroyPS;
    public GameObject idlePS;
    public AudioSource powerUpSFX;

    private void Start()
    {
        idlePS.SetActive(true);
        //destroyPS.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //destroyPS.SetActive(true);
            destroyPS.Play();
            idlePS.SetActive(false);
            powerUpSFX.Play();
            StartCoroutine(Destruir());
            //Destroy(gameObject);


        }
    }
    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

}
