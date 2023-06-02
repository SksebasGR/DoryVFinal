using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToPlayer : MonoBehaviour
{
    public Transform objFollow;
    public float speed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calcula la dirección hacia el objeto seguido
        Vector3 direccion = objFollow.position - transform.position;

        // Mueve el objeto que sigue hacia el objeto seguido
        transform.position = Vector3.MoveTowards(transform.position, objFollow.position, speed * Time.deltaTime);
        
        // Calcula el ángulo de rotación hacia el objeto seguido
        float targetRotation = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;

        // Aplica la rotación gradualmente en el plano 2D
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, targetRotation), rotationSpeed * Time.deltaTime);
    }
   
    
           
}
