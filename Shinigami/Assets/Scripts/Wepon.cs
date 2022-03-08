using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepon : MonoBehaviour
{
    public Transform firepoint;
    public float damage2Player;
    public ParticleSystem impactEffect;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))//Temporal : testeo del shoot de enemigos, luego tendra que incorporarse la IA
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firepoint.position, firepoint.right);
        
        if (hitInfo)
        {
            Debug.Log(hitInfo.transform.name); //Imprime Room1 :(
            Health player = hitInfo.transform.GetComponent<Health>();
            if(player != null)
            {
                player.TakeDamage(damage2Player);
                Instantiate(impactEffect, hitInfo.point, Quaternion.identity);

            }

        }
    }
}
