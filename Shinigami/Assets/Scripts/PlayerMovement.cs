using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    [SerializeField] float runSpeed = 20f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
