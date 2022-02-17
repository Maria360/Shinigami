using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    [SerializeField] float runSpeed = 20f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool dash = false;
    float timer = 0f;
    bool dashReady;
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            //dash = false;
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && !dash && controller.m_Grounded)//&& dashReady)
        {
            dash = true;
        }
        else if (dash && controller.dashTime<=0)
        {
            dash = false;
            controller.dashTime = controller.startDashTime;
        }
        /*if (dash)
        {
            timer += Time.deltaTime;
            if (timer >= 2f)
            {

            }
        }*/
        /*else if (Input.GetKeyUp(KeyCode.E))
        {
            dash = false;

        }*/
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnRolling(bool isRolling)
    {
        animator.SetBool("IsRolling", isRolling);
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump, dash);
        jump = false;
        //dash = false;
    }

}
