using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Este evento se activará cuando otro collider entre en el área del trigger del cilindro
    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisionó tiene la etiqueta "Cube" o "Finish"
        if (other.CompareTag("Cube") || other.CompareTag("Finish"))
        {
            // Muestra un mensaje en la consola con la etiqueta del objeto que colisionó
            Debug.Log("Colisión con objeto de etiqueta: " + other.tag);
        }
    }
}
