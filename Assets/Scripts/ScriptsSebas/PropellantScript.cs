using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellantScript : MonoBehaviour
{
    public ParticleSystem propellantParticlesRight;  // Referencia al componente ParticleSystem del propulsor de la derecha
    public ParticleSystem propellantParticlesLeft;  // Referencia al componente ParticleSystem del propulsor de la izquierda
    private bool isSKeyPressed;  // Variable para rastrear si la tecla "S" está siendo presionada

    private void Start()
    {
        propellantParticlesRight.Stop();
        propellantParticlesLeft.Stop();
    }

    void Update()
    {
        
        // Verificar si la tecla "S" está siendo presionada
        if (Input.GetKey(KeyCode.S))
        {
            // Activar las partículas del propulsor
            if (!isSKeyPressed)
            {
                propellantParticlesRight.Play();
                propellantParticlesLeft.Play();
                isSKeyPressed = true;
            }
        }
        else
        {
            // Desactivar las partículas del propulsor
            if (isSKeyPressed)
            {
                propellantParticlesRight.Stop();
                propellantParticlesLeft.Stop();
                isSKeyPressed = false;
            }
        }
    }

}
