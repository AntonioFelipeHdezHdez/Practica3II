using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer12 : MonoBehaviour
{ 
    public bool moverHaciaEsfera = false;
    public float speed = 2.0f;
    public Vector3 moveDirection = new Vector3(0, 0, 0);
    public bool useWorldSpace = false;
    GameObject esfera;
    // Start is called before the first frame update
    void Start()
    {
        esfera = GameObject.FindWithTag("Finish");
    }

    // Update is called once per frame
    void Update()
    {
        if (moverHaciaEsfera) {
            transform.LookAt(esfera.transform); 
            moveDirection = transform.forward; 
            moveDirection = moveDirection.normalized;
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed, Space.World);  // Negativo para mover hacia atrás
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * speed, Space.World);  // Negativo para mover hacia la izquierda
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }
    }
}

/* Informe:
Al hacer la masa de la esfera 10 veces mayor, el cilindor la empuja muy poco, y si es al revés, la empuja fácilmente. Si hago la esfera cinemática, está no se mueve. Al duplicar la 
fricción no pasaría nada porque por defecto es cero. pero cuanto mas alta la fricción, más lento cae la esfera.
*/