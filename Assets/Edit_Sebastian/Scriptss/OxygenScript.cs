using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenScript : MonoBehaviour
{
    [SerializeField] private GameObject efect;
    [SerializeField] private float countPoints;
    [SerializeField] private OxygenScore _points;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _points.ChangeFillAmount(countPoints);
            _points.ChangeTime(10);
            Debug.Log("deberia destruirme");
            //Instantiate(efect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }

    
    
}
