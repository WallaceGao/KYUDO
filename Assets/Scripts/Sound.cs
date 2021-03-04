using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string _Name;
    public AudioClip _Clip;

    [Range(0.0f, 1.0f) ]
    public float _Volume;
    [Range(0.1f, 3.0f)]
    public float _Pitch;

    [HideInInspector]
    public AudioSource source;
}

