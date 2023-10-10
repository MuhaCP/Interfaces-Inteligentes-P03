using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8 : MonoBehaviour
{   
    public float speed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Utilizar el eje “Horizontal” para girar el objetivo y que avance siempre en la dirección hacia adelante.
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        Vector3 puntoFinal = transform.position + transform.forward * 10;
        Debug.DrawLine(transform.position, puntoFinal, Color.red);

    }
}
