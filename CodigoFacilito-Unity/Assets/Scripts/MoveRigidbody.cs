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
}
