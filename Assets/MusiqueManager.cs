using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiqueManager : MonoBehaviour
{
    public AudioClip initialClip;
    public AudioClip loopClip;

    private AudioSource audioSource;
    private bool initialClipPlayed = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayInitialAudio();
    }

    void Update()
    {
        // Check if the initial audio has finished playing and the loop clip hasn't started yet
        if (!audioSource.isPlaying && !initialClipPlayed)
        {
            PlayLoopAudio();
        }
    }

    void PlayInitialAudio()
    {
        if (initialClip == null) return;

        audioSource.clip = initialClip;
        audioSource.loop = false; // Ensure the initial clip doesn't loop
        audioSource.Play();
    }

    void PlayLoopAudio()
    {
        if (loopClip == null) return;

        audioSource.clip = loopClip;
        audioSource.loop = true; // Enable looping for the loop clip
        audioSource.Play();
        initialClipPlayed = true; // Prevents this block from being executed again
    }
}
