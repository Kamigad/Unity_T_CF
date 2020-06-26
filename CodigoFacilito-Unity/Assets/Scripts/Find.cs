using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour
{
    // Awake: funcion de monobehavior que se ulitiliza para encontrar objetos y almacenar todos los componenetes. Se ejecuta antes del Start
    private void Awake()
    {
        // forma de encontrar la camara por medio del nombre
        // forma de encontrar la camara por medio del Tag
        // forma de econtrar la camara principal por medio de la clase Carama y la variable main
        // Debug.Log: se encarga de imprimir un mensaje en la consola, en este caso, la position de la camara
        GameObject camara = GameObject.Find("Main Camera");
        camara = GameObject.FindGameObjectWithTag("MainCamera");
        GameObject mCamara = Camera.main.gameObject;
        Debug.Log(camara.transform.position);
        Debug.Log(mCamara.transform.position);
    }
}
