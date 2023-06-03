using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DeathController : MonoBehaviour
{

    [SerializeField] public GameObject _depth;
    [SerializeField] public GameObject _time;
    [SerializeField] private AudioClip sound;
    public ParticleSystem xplode;
    [SerializeField] public GameObject panel;
    public float Delay = 1f;



    void Start()
    {
        
        xplode.Stop();
        

    }


    private void OnCollisionEnter(Collision collision)
    {


        // Verifica si la colisión es con el objeto que debe causar la muerte
        if (collision.gameObject.CompareTag("Enemy"))
        {



            // Instancia el efecto de muerte en la posición de la colisión
            Instantiate(xplode, collision.contacts[0].point, Quaternion.identity);
            

            // Desactiva el objeto del personaje para que no se pueda mover
            SoundXplosionController.Instance.Sound(sound);
            gameObject.SetActive(false);
            Invoke("delayFunction", Delay);

        }
    } 

    void delayFunction()
    {
        _time.SetActive(false);
        _depth.SetActive(false);
        panel.SetActive(true);
    }

}
