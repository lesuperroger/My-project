using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Variable player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        player = col.GetComponent<Variable>();
        player.pv = 0;
    }
}
