using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDm : MonoBehaviour
{
    public int dm = 1;
    public float kbTime;
    private PlayerSoundManager playerSoundManager;
    private void Start()
    {
        playerSoundManager = GetComponent<PlayerSoundManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerJouet playerScript = collision.gameObject.GetComponent<PlayerJouet>();
            if (playerScript != null)
            {
                // Now you can call any public function from PlayerJouet
                playerSoundManager.PlayHit();
                bool isRight = collision.transform.position.x <= transform.position.x;
                playerScript.TakeDamage(isRight, dm);
                Debug.Log("Accessed PlayerJouet script via Collision!");
            }
            else
            {
                Debug.Log("le PlayerScript est null");
            }
        }
    }
}
