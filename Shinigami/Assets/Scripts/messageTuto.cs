using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageTuto : MonoBehaviour
{
    //public float a;
    public GameObject canvasMessage;
    private void Start()
    {
        canvasMessage.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canvasMessage.SetActive(true);
        }
    }
}
