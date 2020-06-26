using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Funcion que es llamada mas de una vez en cada frame, con esta funcion no es necesario multiplicar por Time.deltaTime
    // ademas, cada vez que usemos o implementemos fisicas debe ser dentro de FixedUpdate
    void FixedUpdate()
    {
        // Por medio del Rigidbody podremos mover de forma continua teniendo en cuenta su masa al gameobject
        GetComponent<Rigidbody>().AddForce(Vector3.up * 50f, ForceMode.Force);
    }
}
