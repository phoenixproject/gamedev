using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    Rigidbody rigidbodyJogador;
    float velocidade = 10f;
    AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyJogador = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Parâmetros de Vector3(X,Y,Z)

        // Se foi pressionado a seta para cima
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("Frente");
            // Para frente no eixo Z
            rigidbodyJogador.AddForce(new Vector3(0, 0, 1) * velocidade);
        }

        // Se foi pressionado a seta para baixo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("Trás");
            // Para trás no eixo Z
            rigidbodyJogador.AddForce(new Vector3(0, 0, -1) * velocidade);
        }

        // Se foi pressionado a seta para esquerda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("Esquerda");
            // Para esquerda no eixo X
            rigidbodyJogador.AddForce(new Vector3(-1, 0, 0) * velocidade);
        }

        // Se foi pressionado a seta para direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("Direita");
            // Para direita no eixo X
            rigidbodyJogador.AddForce(new Vector3(1, 0, 0) * velocidade);
        }
    }

    private void OnCollisionEnter(Collision objetocolidido)
    {
        if (objetocolidido.transform.CompareTag("Pontos"))
        {
            Destroy(objetocolidido.gameObject);

            GameObject pontos = GameObject.FindGameObjectWithTag("ObjetoDePontos");
            pontos.GetComponent<Pontuador>().Pontuar();

            audio.Play();
            // Debug.Log(objetocolidido.transform.name);
        }
    }
}
