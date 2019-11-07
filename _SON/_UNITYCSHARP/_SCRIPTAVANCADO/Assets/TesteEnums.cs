using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteEnums : MonoBehaviour
{
    public enum Lumininosidade { baixo, medio, alto };
    public Lumininosidade nivelDeIntensidade;
    Light luz;

    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();

        if(nivelDeIntensidade == Lumininosidade.baixo)
        {
            // Debug.Log("Baixo");
            luz.intensity = 0.2f;
        }
        else
            if (nivelDeIntensidade == Lumininosidade.medio)
            {
                // Debug.Log("Médio");
                luz.intensity = 0.7f;
            }
            else
            {
                // Debug.Log("Alto");
                luz.intensity = 1.2f;
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
