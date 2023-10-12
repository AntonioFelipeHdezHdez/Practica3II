using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer1 : MonoBehaviour
{
    public float velocidad = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow: " + velocidad * Input.GetAxis("Vertical"));
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow: " + velocidad * Input.GetAxis("Vertical"));
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("LeftArrow: " + velocidad * Input.GetAxis("Horizontal"));
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow: " + velocidad * Input.GetAxis("Horizontal"));
        }
    }
}
