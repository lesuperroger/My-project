using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    private string layerNameP = "player";// layer mask qui detecte si c'est un player
    private LayerMask layerMaskP;// layer mask qui detecte si c'est un player
    public float bumpingJump = 70000f;
    private Rigidbody2D rb;
    private PlayerSoundManager playerSoundManager;
    private void Start()
    {
        playerSoundManager = GetComponent<PlayerSoundManager>();
        layerMaskP = (LayerMask)LayerMask.GetMask(layerNameP);// layer mask qui detecte si c'est un player
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((((int)1 << col.gameObject.layer) & layerMaskP) != 1) // layer mask qui detecte si c'est un player
        {
            rb = col.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                playerSoundManager.PlayHit();
                Vector2 direction = Vector2.up * bumpingJump;
                rb.velocity = direction * Time.deltaTime;
            }
        }
    }
}
