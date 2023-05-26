using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    public float speed;
    public float _rotationSpeed;
    private float _horizontal;
    private float _vertical;
    private Animator _sides;

    
        
    // Start is called before the first frame update
    void Start()
    {
        //_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal") * speed;
        _vertical = Input.GetAxisRaw("Vertical") * speed;
        transform.Translate(_horizontal * Time.deltaTime,_vertical * Time.deltaTime, 0);

        
        
       




    }

   

    
}

