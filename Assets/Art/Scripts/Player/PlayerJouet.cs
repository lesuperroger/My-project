using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJouet : MonoBehaviour
{
    public int pv = 3;
    public int jumpForce = 10;
    public int speed = 10;
    private bool isOnGround = true;
    private Rigidbody2D rb;

    private float move;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        float dirRotation = Convert.ToInt32(Input.GetKey(KeyCode.LeftArrow)) - Convert.ToInt32(Input.GetKey(KeyCode.RightArrow));

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
<<<<<<< Updated upstream
        if(Input.GetButtonDown("Jump"))
            rb.AddForce(jumpForce * transform.up);
=======
        if (Input.GetKeyDown(KeyCode.Space) && isGrouded)
            rb.velocity = (jumpForce * transform.up);
>>>>>>> Stashed changes
    }
}
