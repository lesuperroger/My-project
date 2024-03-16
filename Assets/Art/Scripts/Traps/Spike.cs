using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private PlayerJouet player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("TRIGGER");
        player = col.GetComponent<PlayerJouet>();
        player.pv = 0;
    }
}
