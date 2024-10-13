using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioClip redAmmoSound;
    [SerializeField] private AudioClip greenAmmoSound;
    [SerializeField] private AudioClip blueAmmoSound;

    [SerializeField] private AudioClip backgroundMusic;

    private AudioSource audioSource;
    private AudioSource musicSource;

    private bool isMuted = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            // Initialize the AudioSource
            AudioSource[] audioSources = GetComponents<AudioSource>();
            if (audioSources.Length < 2)
            {
                UnityEngine.Debug.LogError("Manque d'audio");
            }

            audioSource = audioSources[0];
            musicSource = audioSources[1];
        }
    }

    private void Start()
    {
        // Ensure that the game starts with sound enabled
        ToggleMute(false);

        if (!IsMainMenuScene())
        {
            PlayBackgroundMusic();
        }
    }

    public void PlayBackgroundMusic()
    {
        if (backgroundMusic != null && !musicSource.isPlaying)
        {
            musicSource.clip = backgroundMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    private bool IsMainMenuScene()
    {
        // Check if the current scene is the Main Menu
        return SceneManager.GetActiveScene().name == "MainMenu";
    }

    public void PlayShootSound(string ammoType)
    {
        if (isMuted) return; 

        switch (ammoType)
        {
            case "red":
                audioSource.PlayOneShot(redAmmoSound);
                break;
            case "green":
                audioSource.PlayOneShot(greenAmmoSound);
                break;
            case "blue":
                audioSource.PlayOneShot(blueAmmoSound);
                break;
        }
    }

    public void ToggleMute(bool mute)
    {
        if (audioSource == null)
        {
            UnityEngine.Debug.LogError("AudioSource not initialized");
            return;
        }

        isMuted = mute;
        audioSource.mute = mute;  
        musicSource.mute = mute;
    }

    public void StopBackgroundMusic()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }
}
