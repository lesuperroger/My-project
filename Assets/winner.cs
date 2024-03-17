using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour
{
    public GameObject winnerPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winnerPanel.SetActive(true);
    }
}
