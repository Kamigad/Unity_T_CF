using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // variable de tipo float que usare para rotar el GameObject
    // con el public ahora nuestrsa variables podran ser vistas y modificadas desde Unity
    // creamos una variable de tipo color que se encargara de darle un color al meterial de nuestro objeto
    public float deltaRotation= 30f;
    public float deltaMovement = 10f;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        //con es linea el material de nuestro objeto tomara el colo que queramos desde el inspecto y se lo pasara a nuestro objeto
        GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Movement();
    }

    void Rotate ()
    {
        // variable transform con la funcion Rotate se encarga de la rotacion del objeto en 3D
        // El Time.deltaTime se encarga de que el movimiento por cuadros del objeto sea el mismo en esta maquina como en cualquier maquina que sea descargada
        // si la tecla que estamos presionando es la Q entonces girara -30f y si la tecla que estoy presionando es la E girara 30f con la clase Input
        
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0f, -deltaRotation, 0f) * Time.deltaTime);
        } else if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0f, deltaRotation, 0f) * Time.deltaTime);
        }
        
    }

    void Movement ()
    {
        if(Input.GetKey(KeyCode.W))
        {
            // llamamos un funcion de transform llamado Translate que se encargara de transaldar nuestro transform con respecto a un vector ya existente
            // vector3.forward es quien respectivamente: (0, 0, 1)
            transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.S))
        {
            // llamamos un funcion de transform llamado Translate que se encargara de transaldar nuestro transform con respecto a un vector ya existente
            // vector3.forward es quien respectivamente: (0, 0, 1)
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // llamamos un funcion de transform llamado Translate que se encargara de transaldar nuestro transform con respecto a un vector ya existente
            // vector3.forward es quien respectivamente: (0, 0, 1)
            transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // llamamos un funcion de transform llamado Translate que se encargara de transaldar nuestro transform con respecto a un vector ya existente
            // vector3.forward es quien respectivamente: (0, 0, 1)
            transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
        }
    }
}
