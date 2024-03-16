using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpike : MonoBehaviour
{
    private Variable player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        player = col.GetComponent<Variable>();
        player.pv = 0;
    }
}
