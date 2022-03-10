using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float Range;

    Rigidbody2D rb2d;
    public float movement_speed;
    public Animator anim;
    private bool right;
    
    void Start()
    {
        right = true;
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerdistance = Vector2.Distance(transform.position, player.position);

        if (playerdistance < Range)
        {
            anim.SetBool("alive", true);
            anim.SetBool("follow", true);
            StartCoroutine("Esperar");
        }

        else

        {
            NoFollowPlayer();
            anim.SetBool("idle", true);
            anim.SetBool("follow", false);
        }
    }

    private void FollowPlayer()
    {
        if (transform.position.x < player.position.x && !right)
        {
            
            rb2d.velocity = new Vector2(movement_speed, 0f);
            Flip();
        }
        else if(transform.position.x > player.position.x && right)
        {
            rb2d.velocity = new Vector2(-movement_speed, 0f);
            Flip();
        }
        else if(!right)
        {
            rb2d.velocity = new Vector2(-movement_speed, 0f);
        }

        else if (right)
        {
            rb2d.velocity = new Vector2(movement_speed, 0f);
        }
    }

    private void NoFollowPlayer()
    {
        rb2d.velocity = Vector2.zero;
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(2);
        FollowPlayer();
        anim.SetBool("idle", false);
        

    }

    private void Flip()
    {
        right = !right;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
}
