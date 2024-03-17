using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rebond : MonoBehaviour
{
    private string layerNameP = "player";// layer mask qui detecte si c'est un player
    private string layerNameG = "ground";// layer mask qui detecte si c'est le sol
    private LayerMask layerMaskP;// layer mask qui detecte si c'est un player
    private LayerMask layerMaskG;// layer mask qui detecte si c'est le sol
    private PlayerJouet player;
    public Rigidbody2D rb;
    public float bumpSpeed = 500f;

    private PlayerSoundManager playerSoundManager;
    private void Start()
    {
        playerSoundManager = GetComponent<PlayerSoundManager>();
        rb = gameObject.GetComponentInParent<Rigidbody2D>();
        layerMaskP = (LayerMask)LayerMask.GetMask(layerNameP);// layer mask qui detecte si c'est un player
        layerMaskG = (LayerMask)LayerMask.GetMask(layerNameG);// layer mask qui detecte si c'est le sol
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if((((int) 1<< col.gameObject.layer ) & layerMaskP ) !=1) // layer mask qui detecte si c'est un player
        {
            player = col.GetComponent<PlayerJouet>();
            if (player != null) 
            {
                playerSoundManager.PlayHit();
                player.Death();
            }
        }
        if ((((int)1 << col.gameObject.layer) & layerMaskG) != 1) // layer mask qui detecte si c'est le sol
        {
            Vector2 direction = Vector2.up.normalized * bumpSpeed;
            if (rb != null) 
            {
                playerSoundManager.PlayJump();
                rb.velocity = (direction * Time.deltaTime);
            }
        }
    }
}
