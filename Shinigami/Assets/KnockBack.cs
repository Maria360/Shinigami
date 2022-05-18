using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public float knockbackstrenght;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
        if(rb != null)
        {
            Vector3 direction = collision.transform.position - transform.position;
            rb.AddForce(direction.normalized * knockbackstrenght, ForceMode2D.Impulse);
        }
    }
    
}
