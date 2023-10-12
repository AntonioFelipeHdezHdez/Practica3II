using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3 : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector3 moveDirection = new Vector3(0, 0, 0);
    public bool useWorldSpace = false;
    GameObject esfera;
    // Start is called before the first frame update
    void Start()
    { // hacer que el cubo empiece en y=0
        //transform.position = new Vector3(0, 0, 0);

        esfera = GameObject.FindWithTag("Finish");
    }

    // Update is called once per frame
    void Update()
    {
        //moveDirection = esfera.transform.position - transform.position; // Ejercicio 6
        transform.LookAt(esfera.transform); // Ejercicio 7
        moveDirection = transform.forward; // Ejercicio 8
        moveDirection = moveDirection.normalized;
        if (useWorldSpace)
        {
            // Movimiento relativo al sistema de referencia mundial
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
        else
        {
            // Movimiento relativo al sistema de referencia local
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        }

        // Ejercicio 4

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}

/*
Resultados del ejercicio 3:
a) Al duplicar las coordenadas del vector, normalizo automaticamente a 1 para que lo que determine al velocidad sea speed y el vector solo la dirección.
b) Al duplicar la velocidad, el cubo se mueve el doble de rápido.
c) No pasa nada, solo va mas lento.
d) Nada, que esta en otra posición.
e) No pasa nada. A no ser que rotes el cubo, entonces serían sistemas de referencia diferentes.
*/

