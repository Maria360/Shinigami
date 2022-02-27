using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    public float dummyHealth;
    public float damage2Dummy;
    public ParticleSystem deadDummyEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            dummyHealth -= damage2Dummy;
            if (dummyHealth<= 0)
            {
                deadDummyEffect.Play();

                Destroy(gameObject);
            }
        }
    }
}
