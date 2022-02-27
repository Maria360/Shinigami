using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dummy : MonoBehaviour
{
    public float dummyHealth;
    public float damage2Dummy;
    public ParticleSystem deadDummyEffect;
    public GameObject HealthBarPanel;
    Slider slider;
    private void Start()
    {
        HealthBarPanel.SetActive(false);
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = dummyHealth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            HealthBarPanel.SetActive(true);
            dummyHealth -= damage2Dummy;
            slider.value = dummyHealth;

            if (dummyHealth<= 0)
            {
                deadDummyEffect.Play();
                Destroy(gameObject);
            }
        }
    }
}
