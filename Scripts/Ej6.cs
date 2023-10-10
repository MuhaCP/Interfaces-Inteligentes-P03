using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6 : MonoBehaviour
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
        // sacar la direccion de la esfera
        Vector3 direction = sphere.transform.position - transform.position;

        // mover cubo hacia la esfera con velocidad speed, la velocidad no esta conditionada por la distancia entre el cubo y la esfera
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
