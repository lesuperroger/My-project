using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private PlayerJouet player;
    public int dm = 1;
    private PlayerSoundManager playerSoundManager;
    private void OnTriggerEnter2D(Collider2D col)
    {

        playerSoundManager = GetComponent<PlayerSoundManager>();
        player = col.GetComponent<PlayerJouet>();
        if(player != null) 
        {
            player.TakeDamage(true, dm);
            playerSoundManager.PlayHit();
        }
    }
}
