using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    public GameObject deathEffect;
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisión es con el objeto que debe causar la muerte
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Instancia el efecto de muerte en la posición de la colisión
            Instantiate(deathEffect, collision.contacts[0].point, Quaternion.identity);

            // Desactiva el objeto del personaje para que no se pueda mover
            gameObject.SetActive(false);
            Debug.Log("mori");
        }
    }
}
