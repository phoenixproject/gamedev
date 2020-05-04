using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linear : MonoBehaviour
{
    private CharacterController ControllerObjeto;
    public float velocidade = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        ControllerObjeto = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Os parâmetros abaixo querem dizer:
        // Uma casa da Unity (Vector3.forward) vezes a velocidade (10) por segundo (Time.deltaTime).
        // Em outras palavras está se movimentando a 10 casas por segundo.
        ControllerObjeto.Move(Vector3.forward * velocidade * Time.deltaTime);
    }
}
