using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slidercheat : MonoBehaviour
{
    public float damage;
    public PowerUp powerUp;
    public ParticleSystem destroyPS;
    public GameObject PowerBarPanel;
    Slider slider;

    private void Start()
    {
        powerUp = FindObjectOfType<PowerUp>();
        slider = PowerBarPanel.GetComponent<Slider>();
        slider.value = damage;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Power Up"))
        {
            destroyPS.Play();
            damage += 2.5f;
            slider.value = damage;
            Destroy(collision.gameObject);
        }
    }
}
