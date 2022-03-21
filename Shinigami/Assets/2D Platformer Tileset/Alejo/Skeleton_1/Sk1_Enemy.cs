using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sk1_Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public int rutina;
    public float cronometro;
    public Animator anim;
    public int direccion;
    public float speed_run;
    public GameObject target;
    public bool atacando;

    public float rango_vision;
    public float rango_ataque;
    public GameObject rango;
    public GameObject Hit;
    RaycastHit hit;
    public LayerMask LayerM;
    public float distance;
    public bool right;

    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        comportamiento();
        
        
        if(Physics2D.Raycast(transform.position, transform.right, distance, LayerM))
        {
            right = !right;
        }
    }

    public void comportamiento()
    {
        if(Mathf.Abs(transform.position.x - target.transform.position.x) > rango_vision && !atacando && right )
        {
            
            anim.SetBool("run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 1.5)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }

            switch(rutina)
            {
                case 0:
                    anim.SetBool("run", false);
                    break;

                case 1:
                    direccion = Random.Range(0, 2);
                    rutina++;
                    break;

                case 2:
                    switch (direccion)
                    {
                        case 0:
                            transform.rotation = Quaternion.Euler(0, 0, 0);
                            transform.Translate(Vector3.right * speed_run * Time.deltaTime);
                            break;

                        case 1:
                            transform.rotation = Quaternion.Euler(0, 180, 0);
                            transform.Translate(Vector3.right * speed_run * Time.deltaTime);
                            break;
                    }
                    anim.SetBool("run", true);
                    break;
            }

        }

        else
        {
            if (Mathf.Abs(transform.position.x - target.transform.position.x) > rango_vision && !atacando)
            {
                if(transform.position.x < target.transform.position.x)
                {
                    anim.SetBool("run", true);
                    transform.Translate(Vector3.right * speed_run * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    anim.SetBool("attack", false);
                }
                else
                {
                    anim.SetBool("run", true);
                    transform.Translate(Vector3.right * speed_run * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    anim.SetBool("attack", false);
                }
            }
            else
            {
                if(!atacando)
                {
                    if(transform.position.x < target.transform.position.x)
                    {
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                    }
                    anim.SetBool("run", false);
                }
            }
        }



    }

    public void Final_ani()
    {
        anim.SetBool("attack", false);
        atacando = false;
        rango.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void ColliderWeaponTrue()
    {
        Hit.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void ColliderWeaponFalse()
    {
        Hit.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.right * distance);
    }

 
}
