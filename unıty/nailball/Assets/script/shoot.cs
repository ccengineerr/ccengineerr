using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 2000, ForceMode.Acceleration);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
