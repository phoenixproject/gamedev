using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Carro c1 = new Carro();
        c1.cor = "Amarelo";
        c1.modelo = "UNO";
        c1.qtdeGas = 4;
        c1.velocidadeAtual = 0;
        c1.velocidadeMaxima = 137.5f;
        c1.printAll();
        c1.Acelerar();
        c1.Abastecer();
        Debug.Log("=================================");
        Carro c2 = new Carro();
        c2.cor = "Azul";
        c2.modelo = "Fusca";
        c2.qtdeGas = 2;
        c2.velocidadeAtual = 30.4f;
        c2.velocidadeMaxima = 92.3f;
        c2.printAll();
        c2.Acelerar();
        c2.Abastecer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
