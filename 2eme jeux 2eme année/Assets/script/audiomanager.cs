using System;
using UnityEngine.Audio;
using UnityEngine;


public class audiomanager : MonoBehaviour
{
    public sound[] sounds;

    void Awake()
    {
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.Name == name);
        s.source.Play();
    }
}
