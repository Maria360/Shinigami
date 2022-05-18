using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyyyy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destroyobj"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
