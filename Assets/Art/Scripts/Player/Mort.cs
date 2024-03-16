using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mort : MonoBehaviour
{
    private PlayerJouet player;
    void Update()
    {
        player = gameObject.GetComponent<PlayerJouet>();
        if (player.pv >= 0) 
        {
            Debug.Log("ecran de gameover");
        }
    }
}
