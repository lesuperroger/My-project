using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDm : MonoBehaviour
{

    public PlayerJouet playerJouet;
    public int dm = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerJouet.TakeDamage();
        }
    }
}
