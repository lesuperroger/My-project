using UnityEngine.Audio;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour
{
    // Variable son
    public AudioSource audioSource;
    public AudioClip[] soundMarche;
    public AudioClip[] soudJump;
    public AudioClip[] soudHit;
    // Start is called before the first frame update
    public void playMarche()
    {
        if (soundMarche.Length > 0)
        {
            // Select a random clip
            int randomIndex = Random.Range(0, soundMarche.Length);
            AudioClip clip = soundMarche[randomIndex];

            // Play the selected clip
            audioSource.PlayOneShot(clip);
        }
    }
}
