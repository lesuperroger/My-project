using UnityEngine.Audio;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour
{
    // Variable son
    public AudioSource audioSource;
    public AudioClip[] soundMarche;
    public AudioClip[] soundFlip;
    public AudioClip[] soundJump;
    public AudioClip[] soundHit;
    public AudioClip[] soundDeath;
    public AudioClip[] soundImpactGround;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Play(AudioClip[] ac, string debugString = "Son")
    {
        if (ac.Length > 0)
        {

            int randomIndex;
            // Select a random clip
            if (ac.Length == 1)
            {
                randomIndex = 0;
            }
            else
            {
                randomIndex = Random.Range(0, ac.Length);
            }
            AudioClip clip = ac[randomIndex];

            // Play the selected clip
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.Log( nameof(ac) + " n'est pas définit pour " + gameObject.name);
        }
    }
    public void PlayMarche()
    {
        Play(soundMarche, "soundMarche");
    }
    public void PlayFlip()
    {
        Play(soundFlip, "soundFlip");
    }
    public void PlayJump()
    {
        Play(soundJump, "soundJump");
    }
    public void PlayHit()
    {
        Play(soundHit, "soundHit");
    }
    public void PlayDeath()
    {
        Play(soundDeath, "soundDeath");
    }
    public void PlayImpactGround()
    {
        Play(soundImpactGround, "soundImpactGround");
    }
}
