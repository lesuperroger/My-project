using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private PlayerJouet player;
    public int dm = 1;
    private PlayerSoundManager playerSoundManager;
    private void Start()
    {
        playerSoundManager = GetComponent<PlayerSoundManager>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        player = col.GetComponent<PlayerJouet>();
        if(player != null) 
        {
            playerSoundManager.PlayHit();
            player.TakeDamage(true, dm);
        }
    }
}
