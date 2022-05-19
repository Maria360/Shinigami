using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicageneral : MonoBehaviour
{
    float timer=0f;
    public AudioSource risas;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 20)
        {
            Debug.Log("20 segundos");
            risas.Play();
            timer = 0f;
        }
    }
}
