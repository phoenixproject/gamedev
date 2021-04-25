using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public string modelo;
    public string cor;
    public float velocidadeMaxima;
    public float velocidadeAtual;
    public int qtdeGas;
    public void printAll()
    {
        Debug.Log("Modelo: " +modelo);
        Debug.Log("Cor: " +cor);
        Debug.Log("Velocidade Máxima: " +velocidadeMaxima);
        Debug.Log("Velocidade Atual: " +velocidadeAtual);
        Debug.Log("Qtde.Gás.: " +qtdeGas);
    }
    public void Acelerar()
    {
        if (velocidadeAtual < velocidadeMaxima)
        {
            velocidadeAtual += 5;
        }
        Debug.Log(" ");

        Debug.Log("Velocidade Atual: " +velocidadeAtual);
        Debug.Log(" ");
    }
    public void Abastecer()
    {
        qtdeGas += 2;
        Debug.Log(" ");
        Debug.Log("Qtde.Gás.: " +qtdeGas);
        Debug.Log(" ");
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
