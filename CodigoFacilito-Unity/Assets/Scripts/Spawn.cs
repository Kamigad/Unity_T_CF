using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // prefab sera la variable que almacenara nuestro gameobject desde el inpector
    // count para llevar la cuenta de los prefabs que llevamos
    public GameObject prefab;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // por medio de esta linea de code se utiliza para que aparezca el gameobject que definimos en el inpector. Haciendo uso de el gameobject, la posicion en donde
        // queremos que este aparezca y la rotacion que queremos que tenga. Al usar .position y .rotation indican la posicion y la rotacion del objeto vacio que hay en la
        // escena.
        // siempre y cuando oprima la barra espaciadora aparecera mi prefab en la escena
        // agregando el GetkeyUp, la accion de aparecer se ejecutara siempre y cuando yo suelte la tecla
        if(Input.GetKeyUp(KeyCode.Space))
        {
            // Dado a que el Instatiate al ser llamada nos retorna un objeto, este lo convertiremos en GameObject y lo almacenaremos en una variable, la cual le daremos 
            // nombre y contaremos cuantos se generan para tener mejor control en la escena
            // Funcion Destroy, se encargara de destruir el gameobject cube y cuanto cumpla el lapso de tiempo dado, 3f
            GameObject cube = Instantiate(prefab, transform.position, transform.rotation) as GameObject ;
            cube.name = "Cubo" + " " +count++;
            Destroy(cube, 3f);
        }
    }
}
