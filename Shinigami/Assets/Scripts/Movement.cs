using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float walkspeed;
    [SerializeField] float jumpSpeed;
    [SerializeField] float fallMultiplier;
    [SerializeField] float lowJumpMultiplier;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);

        Walk(dir);
        Jump();
    }
    private void Walk(Vector2 dir)
    {
        rb.velocity = (new Vector2(dir.x * walkspeed, rb.velocity.y));
    }
    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if(rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
