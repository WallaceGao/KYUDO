﻿using UnityEngine;
using UnityEngine.Audio;
using System;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Sound[] _sounds;
    [SerializeField] private string[] _playMusic;
    [SerializeField] private string[] _playMusicLoop;
    [SerializeField] private static SoundManager _instance;
    [SerializeField] private bool _isFocus = false;
    public bool IsFoucs { set { _isFocus = value; } }
    [SerializeField] private float _speedOfChangeFocus = 0.0f;


    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sound s in _sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s._Clip;
            s.source.volume = s._Volume;
            s.source.pitch = s._Pitch;
        }
    }

    private void Start()
    {
        foreach (var name in _playMusic)
        {
            Play(name);
        }
        foreach (var name in _playMusicLoop)
        {
            StartCoroutine(PlayLoop(name));
        }
    }

    public void Update()
    {
        foreach (var name in _playMusicLoop)
        {
            focus(_isFocus,name);
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(_sounds, sound => sound._Name == name);
        if (s == null)
        {
            return;
        }
        s.source.Play();
    }

    IEnumerator PlayLoop(string name)
    {
        while (true)
        {
            Sound s = Array.Find(_sounds, sound => sound._Name == name);
            if (s == null)
            {
                break;
            }

            yield return new WaitUntil(() => s.source.isPlaying == false);
            yield return new WaitForSeconds(UnityEngine.Random.Range(s._randomStarTime, s._randomEndTime));
            s.source.Play();
        }
    }

    public void focus(bool isFocus,string name)
    {
        Sound s = Array.Find(_sounds, sound => sound._Name == name);
        if (s == null)
        {
            return;
        }
        if (isFocus && s.source.volume >= s._FoucsVolume)
        {
            s.source.volume -= _speedOfChangeFocus;
        }
        else if (!isFocus && s.source.volume <= s._Volume)
        {
            s.source.volume += _speedOfChangeFocus;
        }
    }
}
