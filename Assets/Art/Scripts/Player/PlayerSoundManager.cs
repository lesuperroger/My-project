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
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayMarche()
    {
        if (soundMarche.Length > 0)
        {

            int randomIndex;
            // Select a random clip
            if (soundMarche.Length == 1)
            {
                randomIndex = 0;
            }
            else
            {
                randomIndex = Random.Range(0, soundMarche.Length);
            }
            AudioClip clip = soundMarche[randomIndex];

            // Play the selected clip
            audioSource.PlayOneShot(clip);
        }
        else
        {
            string nomObjet = gameObject.name;
            Debug.Log("soundMarche n'est pas set pour " + nomObjet);
        }
    }
    public void PlayFlip()
    {
        if (soundFlip.Length > 0)
        {

            int randomIndex;
            // Select a random clip
            if (soundFlip.Length == 1)
            {
                randomIndex = 0;
            }
            else
            {
                randomIndex = Random.Range(0, soundFlip.Length);
            }
            AudioClip clip = soundFlip[randomIndex];

            // Play the selected clip
            audioSource.PlayOneShot(clip);
        }
        else
        {
            string nomObjet = gameObject.name;
            Debug.Log("soundMarche n'est pas set pour " + nomObjet);
        }
    }
    public void PlayJump()
    {
        if (soundJump.Length > 0)
        {
            int randomIndex;
            // Select a random clip
            if (soundJump.Length == 1)
            {
                randomIndex = 0;
            }
            else
            {
                randomIndex = Random.Range(0, soundJump.Length);
            }
            AudioClip clip = soundJump[randomIndex];

            // Play the selected clip
            audioSource.PlayOneShot(clip);
        }
        else
        {
            string nomObjet = gameObject.name;
            Debug.Log("soundJump n'est pas set pour " + nomObjet);
        }
    }
    public void PlayHit()
    {
        if (soundHit.Length > 0)
        {
            int randomIndex;
            // Select a random clip
            if (soundHit.Length == 1)
            {
                randomIndex = 0;
            }
            else
            {
                randomIndex = Random.Range(0, soundHit.Length);
            }
            AudioClip clip = soundHit[randomIndex];

            // Play the selected clip
            audioSource.PlayOneShot(clip);
        }
        else
        {
            string nomObjet = gameObject.name;
            Debug.Log("soundJump n'est pas set pour " + nomObjet);
        }
    }
    public void PlayDeath()
    {
        if (soundDeath.Length > 0)
        {
            int randomIndex;
            // Select a random clip
            if (soundDeath.Length == 1)
            {
                randomIndex = 0;
            }
            else
            {
                randomIndex = Random.Range(0, soundDeath.Length);
            }
            AudioClip clip = soundDeath[randomIndex];

            // Play the selected clip
            audioSource.PlayOneShot(clip);
        }
        else
        {
            string nomObjet = gameObject.name;
            Debug.Log("soundDeath n'est pas set pour " + nomObjet);
        }
    }
}
