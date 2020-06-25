using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // variable transform con la funcion Rotate se encarga de la rotacion del objeto en 3D
        // El Time.deltaTime se encarga de que el movimiento por cuadros del objeto sea el mismo en esta maquina como en cualquier maquina que sea descargada
        transform.Rotate(new Vector3 (0f, 30f, 0f) * Time.deltaTime);
    }
}
