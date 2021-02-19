using UnityEngine;
using UnityEngine.Audio;
using System;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;
    public string[] PlayMusic;
    public static SoundManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s._Clip;
            s.source.volume = s._Volume;
            s.source.pitch = s._Pitch;
        }
    }

    private void Start()
    {
        foreach (var name in PlayMusic)
        {
            Play(name);
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound._Name == name);
        if (s == null)
        {
            return;
        }
        s.source.Play();
    }

    //IEnumerator PlaySound(string name)
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(UnityEngine.Random.Range(5, 10));
    //        Sound s = Array.Find(sounds, sound => sound._Name == name);
    //        if (s == null)
    //        {
    //            break;
    //        }
    //        s.source.Play();
    //    }
    //}

}
