using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{

    
    // Start is called before the first frame update
    public void Shoot()
    {
        // uso de fisicas impulsando el objeto de forma inmediata en base a su masa
        // por medio de la funcion Random, podremos elegir entre un numero minimo y un numero maximo aleatoriamente, siendo util en float y enteros
        // se puede usar variables de tipo dependiendo del componente que queramos usar, en este caso, Rigidody
        Rigidbody r = gameObject.GetComponent<Rigidbody>();
        float x = Random.Range(-1f, 1f);
        r.AddForce(new Vector3(x,0f,1f) * 100f, ForceMode.Impulse);
    }

}
