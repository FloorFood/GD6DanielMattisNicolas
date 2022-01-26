using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    //How to use: find or make an approriate location in a script for a sound effect to be triggered.
    //After doing so, type in the following to play a sound: AudioManager.instance.PlaySound("Name of sound");
    //"Name of sound" should of course be switched out with the name of the sound/song you want to be played. Not the file name, but the name given to it in the sounds array inside the AudioManager
    //object.

    //If you want a sound effect to have a random pitch when it plays, you can use "AudioManager.instance.shouldRandomizePitch = true;" before calling the PlaySound function.
    //If you want to play a sound from inside this script instead of in another script, you can leave out the "AudioManager.instance." part of the code. Same thing goes for changing shouldRandomizePitch.

    public Sound[] sounds;
    public static AudioManager instance;
    AudioSource[] allMyAudioSources;

    public bool shouldRandomizePitch;

    public void Awake()
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
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.mix;
        }

        allMyAudioSources = GetComponents<AudioSource>();
    }

    public void PlaySound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound '" + name + "' not found.");
            return;
        }

        if (shouldRandomizePitch)
        {
            s.source.pitch = Random.Range(0.90f, 1.1f);
            s.source.Play();
            shouldRandomizePitch = false;
        }
        else
        {
            s.source.pitch = 1f;
            s.source.Play();
        }

    }
}