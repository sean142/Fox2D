﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource audioSource;
    public AudioClip jumpAudio, hurtAudio, cherryAudio;

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }

        instance = this;
    }

    public void JumpAudio()
    {
        audioSource.clip = jumpAudio;
        audioSource.Play();
    }

    public void HurtAudio()
    {
        audioSource.clip = hurtAudio;
        audioSource.Play();
    }

    public void CherryAudio()
    {
        audioSource.clip = cherryAudio;
        audioSource.Play();
    }
}
