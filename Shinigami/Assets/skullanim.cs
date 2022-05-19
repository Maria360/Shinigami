using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skullanim : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        anim.SetBool("Begin", true);   
    }
    private void Awake()
    {
        anim.SetBool("Begin", true);

    }

}
