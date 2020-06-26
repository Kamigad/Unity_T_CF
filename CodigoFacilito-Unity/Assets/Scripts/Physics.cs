using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Por medio del Rigidbody podremos mover de forma inmediata teniendo en cuenta su masa al gameobject
        GetComponent<Rigidbody>().AddForce(Vector3.right * 50f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
