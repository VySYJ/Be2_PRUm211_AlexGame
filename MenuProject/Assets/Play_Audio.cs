using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Audio : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource backgroundMusic;
    private bool isMusicPlaying = false;

    void Awake()
    {
        if (instance == null)
        {
            // instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayBackgroundMusic()
    {
        if (backgroundMusic != null && !isMusicPlaying)
        {
            backgroundMusic.Play();
            isMusicPlaying = true;
        }
    }

    public void StopBackgroundMusic()
    {
        if (backgroundMusic != null && isMusicPlaying)
        {
            backgroundMusic.Stop();
            isMusicPlaying = false;
        }
    }

    public void LoadScene(string sceneName)
    {
        // Stop background music before loading a new scene
        StopBackgroundMusic();
        SceneManager.LoadScene("ICE");
    }
}
