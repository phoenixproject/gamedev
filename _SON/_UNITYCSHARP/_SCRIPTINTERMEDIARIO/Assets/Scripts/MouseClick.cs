using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Botão Esquerdo do Mouse
        if (Input.GetMouseButtonDown(0))
        {
            print("Bang! Bang!");
        }

        // Botão Direito do Mouse
        if (Input.GetMouseButtonDown(1))
        {
            print("Recarregar");
        }

        // Botão Scroll do Mouse
        if (Input.GetMouseButtonDown(3))
        {
            print("Visualizando");
        }
    }
}
