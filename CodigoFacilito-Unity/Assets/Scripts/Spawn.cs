using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefab;
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
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
