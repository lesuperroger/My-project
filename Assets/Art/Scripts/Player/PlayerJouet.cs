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
    private Rigidbody2D rb;
    private float move;
    private bool isFacingRight;

    public float kbForce;
    public float kbCounter;
    public float kbTotalTime;
    private bool KnockFromRight;
    private bool kbNeedReset = false;
    public SpriteRenderer spriteRenderer;
    public Mort mort;
    // Start is called before the first frame update
    void Start()
    {
        mort = gameObject.GetComponent<Mort>();
        rb = GetComponent<Rigidbody2D>();
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (kbCounter <= 0)
        {
            if (kbNeedReset)
            {
                ChangeColorNormal();
                kbNeedReset = false;
            }
            //movement gauche/droite
            move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(move * speed, rb.velocity.y);
            //flip sprite
            Flip();

            Jump();
        }
        else
        {
            if (KnockFromRight == true)
            {
                rb.velocity = new Vector2(-kbForce, kbForce);
            }
            else if (KnockFromRight == false)
            {
                rb.velocity = new Vector2(kbForce, kbForce);
            }
            kbCounter -= 1 * Time.deltaTime;
        }
    }

    public void TakeDamage(bool isFromRight, int dam)
    {
        Debug.Log("le foutu crane");
        KnockFromRight = isFromRight;
        kbCounter = kbTotalTime;
        pv -= dam;
        if (pv <= 0)
        {
            Death();
        }
        kbNeedReset = true;
        ChangeColorToRed();
    }
    public void Death() {
        //ajout du son de mort
        if (mort != null)
        {
            mort.DeathMecha();
        }
        Destroy(gameObject);
    }

    private void ChangeColorToRed()
    {
        if (spriteRenderer != null)
        {
            // Change the color of the sprite to red
            spriteRenderer.color = new Color(1f, 0f, 0f, 0.5f);
        }
    }
    void ChangeColorNormal()
    {
        // Get the SpriteRenderer component attached to this GameObject
        

        if (spriteRenderer != null)
        {
            // Change the color of the sprite to red
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            rb.velocity = (jumpForce * transform.up);
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y > 0f)
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
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
