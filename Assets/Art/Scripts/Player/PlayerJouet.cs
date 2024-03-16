using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJouet : MonoBehaviour
{
    // Variable movement
    public int pv = 3;
    public int jumpForce = 10;
    public int speed = 10;
    public bool isOnGround = true;
    private float move;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D rb;
    private bool isFacingRight;
    //Variable Knock back
    public float kbForce; // la force du knockback
    public float kbCounter; // le temps le temps qu'il te reste avant de pouvoir bouger
    public float kbTotalTime; // le temps que tu passe sans pouvoir bouger
    private bool KnockFromRight; // de quel cot� viens le coup
    private bool kbNeedReset = false; // si le kb a besoin de se reinitialiser
    //Variable couleur
    public SpriteRenderer spriteRenderer;
    public Mort mort;
    public float tempsPas;
    public float tempsPasMax;
    // manager du sond
    private PlayerSoundManager playerSoundManager;
    // Start is called before the first frame update
    void Start()
    {
        mort = gameObject.GetComponent<Mort>();
        rb = GetComponent<Rigidbody2D>();
        playerSoundManager = GetComponent<PlayerSoundManager>();
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
            // Flip sprite
            Flip();
            if ((move > 0 || move < 0) && tempsPas <= 0 && IsGrounded())
            {
                playerSoundManager.PlayMarche();
                tempsPas = tempsPasMax;
            }
            // Saute

            Jump();
            tempsPas -= Time.deltaTime;
        }
        else
        {
            if (KnockFromRight == true)
            {
                rb.velocity = new Vector2(-kbForce, kbForce);
            }
            else
            {
                rb.velocity = new Vector2(kbForce, kbForce);
            }
            kbCounter -= 1 * Time.deltaTime;
        }
    }

    public void TakeDamage(bool isFromRight, int dam)
    {
        KnockFromRight = isFromRight;
        kbCounter = kbTotalTime;
        pv -= dam;
        if (pv <= 0)
        {
            Death();
        }
        else
        {
            playerSoundManager.PlayHit();
        }
        kbNeedReset = true;
        ChangeColorToRed();
    }
    public void Death() 
    {
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
            spriteRenderer.color = new Color(1f, 0f, 0f, 0.2f);
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
        {
            rb.velocity = (jumpForce * transform.up);
            playerSoundManager.PlayJump();
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 1.1f);
        }
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
            // Son du flip
            playerSoundManager.PlayFlip();
        }
    }
}
