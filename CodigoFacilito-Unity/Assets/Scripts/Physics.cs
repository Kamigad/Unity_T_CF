using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // uso de fisicas impulsando el objeto de forma inmediata en base a su masa
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 100f, ForceMode.Impulse);
    }

}
