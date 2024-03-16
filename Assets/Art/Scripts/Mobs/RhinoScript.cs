using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhinoScript : MonoBehaviour
{

    public int jumpForce = 10;
    [SerializeField] private float dirrection;
    private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        dirrection = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
        if (IsGrounded())
        {
            rb.velocity = new Vector2(jumpForce * dirrection, jumpForce * 1.5f);
        }
    }
    private void Flip()
    {
        if (Physics2D.OverlapCircle(wallCheck.position, 0.2f, wallLayer))
        {
            dirrection *= -1f;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
            rb.velocity = new Vector2(rb.velocity.x * dirrection, rb.velocity.y);
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
