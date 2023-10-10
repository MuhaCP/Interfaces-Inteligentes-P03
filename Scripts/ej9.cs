using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollitionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " ha colisionado con " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " ha colisionado con " + other.gameObject.name);
    }
}
