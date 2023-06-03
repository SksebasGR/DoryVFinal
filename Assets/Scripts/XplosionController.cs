using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XplosionController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] public ParticleSystem explosion;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();

    }

    
    void Update()
    {
        if (!explosion.isPlaying)
        {
            audioSource.Play();
        }
    }
}
