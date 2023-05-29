using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DeathController : MonoBehaviour
{

    private XplosionController bombController;
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
            bombController.audioSource.Play();

            // Desactiva el objeto del personaje para que no se pueda mover

            gameObject.SetActive(false);
            Invoke("delayFunction", Delay);

        }
    }

    void delayFunction()
    {
        panel.SetActive(true);
    }

}
