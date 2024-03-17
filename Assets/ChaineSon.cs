using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaineSon : MonoBehaviour
{
    public float tempsAvantSonMax;
    private float timer;
    private PlayerSoundManager playerSoundManager;
    private void Start()
    {
        timer = 1;
        playerSoundManager = GetComponent<PlayerSoundManager>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime; // Increment the timer by the time since last frame

            if (timer >= tempsAvantSonMax) // Check if a second has passed
            {
                playerSoundManager.PlayHit();
                timer = 0f; // Reset the timer
                Debug.Log("timer marche");
            }
            Debug.Log("touche player");
        }

        Debug.Log("entree collision");
    }
}
