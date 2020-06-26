using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Por medio del Rigidbody podremos mover de forma continua teniendo en cuenta su masa al gameobject
        GetComponent<Rigidbody>().AddForce(Vector3.up * 50f, ForceMode.Force);
    }
}
