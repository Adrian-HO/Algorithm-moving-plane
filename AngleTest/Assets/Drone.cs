using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 60.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(transform.right, rotationSpeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.up, rotationSpeed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.up, -rotationSpeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(transform.forward, rotationSpeed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(transform.forward, -rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}
