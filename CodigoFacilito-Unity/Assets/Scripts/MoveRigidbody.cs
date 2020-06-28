using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidbody : MonoBehaviour
{
    // Variable global para darle velocidad al gameobject
    public float speed;
    
    // funcion usada para el manejo de gravedad
    private void FixedUpdate()
    {
        // Forma de realizar el movimiento simple del objeto haciendo uso del Rigidbody
        if(Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.forward * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.left * speed * Time.deltaTime);
        }

        
    }

    // Funcion de fisica que se usa despues del FixUpdate pero antes del Update
    private void OnCollisionEnter(Collision collision)
    {
        // Imprime en consola el objeto con el que esta chocando el gameobject (cubo) una sola vez
        Debug.Log(collision.gameObject.name);
    }

    // Funcion de fisica que se usa despues del FixUpdate pero antes del Update
    private void OnCollisionStay(Collision collision)
    {
        // Imprime en consola el objeto con el que esta chocando el gameobject (cubo) durante todo el tiempo
        Debug.Log(collision.gameObject.name);
    }

    // Funcion de fisica que se usa despues del FixUpdate pero antes del Update
    private void OnCollisionExit(Collision collision)
    {
        // Imprime en consola el objeto con el que esta chocando el gameobject (cubo) una vez que la colision deja de existir
        Debug.Log(collision.gameObject.name);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
