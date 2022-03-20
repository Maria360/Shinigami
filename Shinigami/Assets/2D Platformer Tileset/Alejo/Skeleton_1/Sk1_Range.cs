using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sk1_Range : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;
    public Sk1_Enemy enemigo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            anim.SetBool("run", false);
            anim.SetBool("attack", true);
            enemigo.atacando = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
