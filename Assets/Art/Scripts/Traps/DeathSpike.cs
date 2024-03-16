using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpike : MonoBehaviour
{
    private PlayerJouet player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        player = col.GetComponent<PlayerJouet>();
        if (player != null) 
        { 
            player.Death(); 
        }
    }
}
