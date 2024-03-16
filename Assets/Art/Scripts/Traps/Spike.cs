using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private Variable player;
    private void OnTriggerEnter(Collider col)
    {
        player = col.GetComponent<Variable>();
        player.pv = -3;
    }
}
