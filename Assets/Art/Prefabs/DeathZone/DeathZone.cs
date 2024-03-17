using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private PlayerJouet player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger");
        player = col.GetComponent<PlayerJouet>();
        if(player != null)
        {
            player.Death(); 
        }
    }
}
