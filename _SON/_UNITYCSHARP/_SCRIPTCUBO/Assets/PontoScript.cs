using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoScript : MonoBehaviour
{
    float velocidadeRotacao = 4f;
    Vector3 rotacao = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(1, 1, 1) * velocidadeRotacao);    
        transform.Rotate(rotacao * velocidadeRotacao);
    }

    private void OnCollisionEnter(Collision objetocolidido)
    {
        if (objetocolidido.transform.CompareTag("Pontos"))
        {
            Destroy(objetocolidido.gameObject);
        }
    }
}
