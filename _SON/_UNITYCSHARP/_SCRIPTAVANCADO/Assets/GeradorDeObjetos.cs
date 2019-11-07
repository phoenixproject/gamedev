using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjetos : MonoBehaviour
{
    public GameObject objeto;
    float z = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("GerarObjeto", 7f, 70f);
    }

    void GerarObjeto()
    {
        Instantiate(objeto, new Vector3(z, z, z), Quaternion.identity);
        z += 1f;
    }
}
