using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptypot : MonoBehaviour
{
    public GameObject destroyPS;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            destroyPS.SetActive(true);

        }
    }
}
