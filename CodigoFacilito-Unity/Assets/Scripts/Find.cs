using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour
{
    // Awake: funcion de monobehavior que se ulitiliza para encontrar objetos y almacenar todos los componenetes. Se ejecuta antes del Start
    private void Awake()
    {
        // mediante la clase GameObject y el metodo FindGameObjectsWithTag, usaremos un tag para que nos retorne un arreglo de GameObjects
        // al hacerlo con el metodo en singular al ser un grupo de objetos con el mismo tag este tomara el primero que encuentre
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Objeto");

        // Despues interamos en cada uno de los GameObjects por medio del foreach, para finalmente imprimir la posicion de cada GameObject
        foreach(GameObject go in objects)
        {
            Debug.Log(go.transform.position);
        }
    }
}
