using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    private string layerNameP = "player";
    private LayerMask layerMaskP;
    private void Start()
    {
        layerMaskP = (LayerMask)LayerMask.GetMask(layerNameP);// layer mask qui detecte si c'est un player
    }
    private PlayerJouet player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((((int)1 << col.gameObject.layer) & layerMaskP) != 1)
        {
            player = col.GetComponent<PlayerJouet>();
            if (player != null)
            {
                player.isOnGround = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (player != null) 
        {
            player.isOnGround = false;
        }
    }
            
}
