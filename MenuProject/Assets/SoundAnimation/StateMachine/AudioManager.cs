using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public GameObject prefab;

    public AudioClip theme;
    private AudioSource themesource;
    public AudioClip run;
    private AudioSource runsource;
    public AudioClip jump;
    private AudioSource jumpsource;
    public AudioClip fall;
    private AudioSource fallsource;
    public AudioClip attack;
    private AudioSource attacksource;
    public AudioClip hurt;
    private AudioSource hurtsource;
    public AudioClip dead;
    private AudioSource deadsource;
    public AudioClip heal;
    private AudioSource healsource;
    public AudioClip mobAttack;
    private AudioSource mobAttacksource;
    public AudioClip mobRoar;
    private AudioSource mobRoarsource;
    public AudioClip mobRun;
    private AudioSource mobRunsource;
    public AudioClip mobDead;
    private AudioSource mobDeadsource;

    public static object Instance { get; internal set; }

    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip clip, float volume, bool isLoopback)
    {
        if (clip == this.theme)
        {
            Play(clip, ref themesource, volume, isLoopback);
        }
    }
    public void PlaySound(AudioClip clip, float volume)
    {
        if (clip == this.run)
        {
            Play(clip, ref runsource, volume);
            return;
        }
        if (clip == this.jump)
        {
            Play(clip, ref jumpsource, volume);
            return;
        }
        if (clip == this.fall)
        {
            Play(clip, ref fallsource, volume);
            return;
        }
        if (clip == this.attack)
        {
            Play(clip, ref attacksource, volume);
            return;
        }
        if (clip == this.hurt)
        {
            Play(clip, ref hurtsource, volume);
            return;
        }
        if (clip == this.dead)
        {
            Play(clip, ref deadsource, volume);
            return;
        }
        if (clip == this.heal)
        {
            Play(clip, ref healsource, volume);
            return;
        }
        if (clip == this.mobAttack)
        {
            Play(clip, ref mobAttacksource, volume);
            return;
        }
        if (clip == this.mobRoar)
        {
            Play(clip, ref mobRoarsource, volume);
            return;
        }
        if (clip == this.mobRun)
        {
            Play(clip, ref mobRunsource, volume);
            return;
        }
        if (clip == this.mobDead)
        {
            Play(clip, ref mobDeadsource, volume);
            return;
        }

    }
    public void Play(AudioClip clip, ref AudioSource audioSource, float volume, bool isLoopback = false)
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            return;
        }
        audioSource = Instantiate(instance.prefab).GetComponent<AudioSource>();

        audioSource.volume = volume;
        audioSource.loop = isLoopback;
        audioSource.clip = clip;
        audioSource.Play();
        Destroy(audioSource.gameObject, audioSource.clip.length);
    }

    public void StopSound(AudioClip clip)
    {
        if (clip == this.run)
        {
            if (runsource != null)
            {
                runsource.Stop();
            }
            return;
        }
        if (clip == this.jump)
        {
            if (jumpsource != null)
            {
                jumpsource.Stop();
            }
            return;
        }
        if (clip == this.fall)
        {
            if (fallsource != null)
            {
                fallsource.Stop();
            }
            return;
        }
        if (clip == this.attack)
        {
            if (attacksource != null)
            {
                attacksource.Stop();
            }
            return;
        }
        if (clip == this.hurt)
        {
            if (hurtsource != null)
            {
                hurtsource.Stop();
            }
            return;
        }
        if (clip == this.dead)
        {
            if (deadsource != null)
            {
                deadsource.Stop();
            }
            return;
        }
        if (clip == this.heal)
        {
            if (healsource != null)
            {
                healsource.Stop();
            }
            return;
        }
        if (clip == this.mobAttack)
        {
            if (healsource != null)
            {
                mobAttacksource.Stop();
            }
            return;
        }
        if (clip == this.mobRoar)
        {
            if (healsource != null)
            {
                mobRoarsource.Stop();
            }
            return;
        }
        if (clip == this.mobRun)
        {
            if (healsource != null)
            {
                mobRunsource.Stop();
            }
            return;
        }
        if (clip == this.mobDead)
        {
            if (healsource != null)
            {
                mobDeadsource.Stop();
            }
            return;
        }

    }

    public static implicit operator AudioManager(Play_Audio v)
    {
        throw new NotImplementedException();
    }
}
