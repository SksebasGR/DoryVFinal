using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSound : MonoBehaviour
{
    private AudioSource audioSource;
    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            
        }
    }




}
