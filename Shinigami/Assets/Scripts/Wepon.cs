using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepon : MonoBehaviour
{
    public Transform firepoint;
    public float damage2Player;
    public LineRenderer line;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))//Temporal : testeo del shoot de enemigos, luego tendra que incorporarse la IA
        {
            StartCoroutine(Shoot());
            //Shoot();
        }
    }
    IEnumerator Shoot()
    {

        RaycastHit2D hitInfo = Physics2D.Raycast(firepoint.position, firepoint.right);

        if (hitInfo)
        {
            

            Debug.Log(hitInfo.transform.name); 
            Health player = hitInfo.transform.GetComponent<Health>();
            if(player != null)
            {

                player.TakeDamage(damage2Player);
                
                //player.impactEffect.Play();
            }
            line.SetPosition(0, firepoint.position);
            line.SetPosition(1, hitInfo.point);
        }
        else
        {
            line.SetPosition(0, firepoint.position);
            line.SetPosition(1, firepoint.position + firepoint.right * 100);

        }
        line.enabled = true;
        yield return new WaitForSeconds(0.002f);
        line.enabled = false;
        //projectile.Play();


    }
}
