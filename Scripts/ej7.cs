using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7 : MonoBehaviour
{   
    public float speed;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // sacar la direccion de la esfera y normalizarla
        Vector3 direction = (sphere.transform.position - transform.position).normalized;

        // mover cubo hacia la esfera con velocidad speed, la velocidad no esta conditionada por la distancia entre el cubo y la esfera
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
        transform.LookAt(sphere.transform);
    }
}
