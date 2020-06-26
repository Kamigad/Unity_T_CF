using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // uso de fisicas impulsando el objeto de forma inmediata en base a su masa
        // por medio de la funcion Random, podremos elegir entre un numero minimo y un numero maximo aleatoriamente, siendo util en float y enteros
        float x = Random.Range(-1f, 1f);
        GetComponent<Rigidbody>().AddForce(new Vector3(x,0f,1f) * 100f, ForceMode.Impulse);
    }

}
