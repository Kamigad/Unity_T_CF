using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // variable global para usar entre diferentes metodos con el tipo del nombre del script que necesitamos
    Uno s1;
    private void Awake()
    {
        // Llamamos a los componentes de la camara principal que esta por fuera de la jeraraquia, puede ser por nombre o por tag, por ser la camara esta tiene una 
        // funcion especial por la cual la llamaremos, Camera 
        // Debug.Log, para imprimir en consola lo que encontramos en Camara principal
        s1 = Camera.main.GetComponent<Uno>();

        Debug.Log(s1);

        // Llamamos los componentes del script Dos, los cuales sabemos que estan en la jerarquia, por lo cual ponemos gameObject haciendo referencia a el mismo y 
        // a sus hijos para encontrar quien tiene el script Dos
        Dos s2 = gameObject.GetComponentInChildren<Dos>();

        Debug.Log(s2);

        // Llamamos los componentes del script Tres, los cuales estan en mas de un gameobject en la jerarquia, por eso lo llamamos como un arreglo y en plural, para
        // hacer referencia a mas de uno 
        // usamos la variante .Length para saber cuantos encontro
        Tres[] s3 = gameObject.GetComponentsInChildren<Tres>();
        Debug.Log(s3.Length);
    }

     void Start()
    {
        // usamos el s1 para llamar el metodo .Test que esta en el script Uno, y ejecutarlo en el script Contoller(en este mismo script)
        s1.Test(); 
    }
}
