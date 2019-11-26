using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToqueBegan : MonoBehaviour
{
    public GameObject cubo;
    int valor=  0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Instantiate(cubo, new Vector3(valor, valor, valor),Quaternion.identity);
        }
    }
}
