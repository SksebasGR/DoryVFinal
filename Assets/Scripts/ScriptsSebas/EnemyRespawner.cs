using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawner : MonoBehaviour
{
    
    
    public float moveSpeed = 10f;
    public float maxHeight = 100f;

    private float initialY;

    private void Start()
    {
        initialY = transform.position.y;
    }

    private void Update()
    {
        float newY = transform.position.y + (moveSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        if (transform.position.y >= initialY + maxHeight)
        {
            // Aquí puedes realizar alguna acción cuando el objeto alcanza la altura máxima
            // Por ejemplo, puedes desactivar el objeto o destruirlo
            //Destroy(gameObject);
            // O bien, puedes resetear su posición al valor inicial
            transform.position = new Vector3(transform.position.x, initialY, transform.position.z);
        }
    }
}