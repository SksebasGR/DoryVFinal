using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenScript : MonoBehaviour
{
    [SerializeField] private GameObject efect;
    [SerializeField] private float countPoints;
    [SerializeField] private OxygenScore _points;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        
        {
            audioSource.Play();
            _points.ChangeFillAmount(countPoints);
            _points.ChangeTime(10);
            //Instantiate(efect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }

    
    
}
