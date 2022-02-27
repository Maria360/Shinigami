using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    AnimationScript anim;
    public bool isAttacking;
    private void Start()
    {
        anim = GetComponent<AnimationScript>();
    }
    private void Attacking()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("attack");
            isAttacking = true;
        }
    }
    private void Update()
    {
        Attacking();
    }
}
