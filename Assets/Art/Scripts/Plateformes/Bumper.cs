using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bumpingJump = 70000f;
    private Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D col)
    {
        rb = col.GetComponent<Rigidbody2D>();
        Vector2 direction = Vector2.up * bumpingJump;
        rb.velocity = direction * Time.deltaTime;
    }
}
