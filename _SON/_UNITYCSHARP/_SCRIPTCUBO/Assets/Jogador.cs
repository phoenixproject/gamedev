using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    Rigidbody rigidbody;
    float velocidade = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Se foi pressionado a seta para cima
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Frente");
        }

        // Se foi pressionado a seta para baixo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Trás");
        }

        // Se foi pressionado a seta para esquerda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Esquerda");
        }

        // Se foi pressionado a seta para direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Direita");
        }
    }
}
