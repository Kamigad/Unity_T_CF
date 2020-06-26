using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // por medio de esta linea de code se utiliza para que aparezca el gameobject que definimos en el inpector. Haciendo uso de el gameobject, la posicion en donde
        // queremos que este aparezca y la rotacion que queremos que tenga. Al usar .position y .rotation indican la posicion y la rotacion del objeto vacio que hay en la
        // escena.
        Instantiate(prefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
