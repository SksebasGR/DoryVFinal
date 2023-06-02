using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    /*
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


        
        if (!Input.GetKey(KeyCode.W))
        {
            return;
        }




    }
    */

    public GameObject proyectilePrefab;
    private float speed = 10f;
    private float Rspeed = 50f;
    public float turnSpeed = 10f;
    public float velocidadGiro = 100f;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        }
        */

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }


    }
}

