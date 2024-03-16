using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    private PlayerJouet player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        player = col.GetComponent<PlayerJouet>();
       if(player != null)
       {
            player.isOnGround = true;
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
