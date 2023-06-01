using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundXplosionController : MonoBehaviour
{

    public static SoundXplosionController Instance;
    private AudioSource _audioSource;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        _audioSource = GetComponent<AudioSource>();
    }

    public void Sound(AudioClip _sound)
    {
        _audioSource.PlayOneShot(_sound);
    }

}
