using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public ParticleSystem destroyPS;
    public GameObject idlePS;
    public AudioSource powerUpSFX;
    Collider2D collider;
    private void Start()
    {
        idlePS.SetActive(true);
        collider = GetComponent<Collider2D>();
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
            collider.enabled = false;
            StartCoroutine(Destruir());
            //Destroy(gameObject);


        }
    }
    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }

}
