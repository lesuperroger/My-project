using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJouet : MonoBehaviour
{
    public int pv = 3;
    public int jumpForce = 10; 
    public int speed = 10;
    public bool isOnGround = true;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask hitPlayer;
    private Rigidbody2D rb;
    private float move;
    private bool isFacingRight;
    private bool isInvincible;
    [SerializeField] private float invincibility;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(pv > 0)
        {

            //movement gauche/droite
            move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(move * speed, rb.velocity.y);
            // Flip sprite
            Flip();
            // Player jump Jump
            Jump();
            //
            DamageCheck();
        }
        else
        {
            //Game over
        }

        
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            rb.velocity = (jumpForce * transform.up);
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y > 0f)
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
    }
    private void DamageCheck()
    {
        if(IsDamaged())
        {
            pv -= 1;

        }
    }
    private bool IsDamaged()
    {
        return false;
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip()
    {
        if (isFacingRight && move < 0f || !isFacingRight && move > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
