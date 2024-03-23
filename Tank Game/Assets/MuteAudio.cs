using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MuteAudio : MonoBehaviour
{
    private AudioSource audioSource; // Reference to the AudioSource component

    public Sprite soundOnSprite; // Sprite for sound on
    public Sprite soundOffSprite; // Sprite for sound off

    private bool isMuted = false; // Flag to track whether sound is muted or not

    private void Start()
    {
        audioSource = GetComponentInChildren<AudioSource>(); // Attempt to find AudioSource in children
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found. Please assign an AudioSource.");
        }
    }

    public void ToggleSound()
    {
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is not assigned or not found.");
            return;
        }

        isMuted = !isMuted; // Toggle the mute flag

        if (isMuted)
        {
            // Mute the audio
            audioSource.volume = 0f;
            GetComponent<Image>().sprite = soundOffSprite; // Change button image to sound off
        }
        else
        {
            // Unmute the audio
            audioSource.volume = 1f; // You can set it to any desired volume level
            GetComponent<Image>().sprite = soundOnSprite; // Change button image to sound on
        }
    }
}
