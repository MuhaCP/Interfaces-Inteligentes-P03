using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej12 : MonoBehaviour
{   
    public float speed;

    private Rigidbody rBody;

    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Vector3 direction = (sphere.transform.position - transform.position).normalized;
            rBody.AddForce(direction * speed);
        }
        else
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed;
            rBody.AddForce(movement);
        }
    }
}
