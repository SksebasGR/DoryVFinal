using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenScript : MonoBehaviour
{
    //[SerializeField] private GameObject efect;
    [SerializeField] private float countPoints;
    [SerializeField] private OxygenScore _points;
    [SerializeField] private AudioClip _collect;





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        
        {
    
            _points.ChangeFillAmount(countPoints);
            _points.ChangeTime(10);
            //Instantiate(efect, transform.position, Quaternion.identity);
            CollectorSound.Instance.Sound(_collect);
            Destroy(gameObject);
            
        }
    }

    
    
}
