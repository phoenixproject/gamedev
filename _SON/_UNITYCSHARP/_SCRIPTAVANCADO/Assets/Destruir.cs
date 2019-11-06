using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            // Destruindo objeto
            Destroy(obj);
            // Destruindo objeto com intervalo de tempo (5 segundos)
            //Destroy(obj,5f);
            // Auto destruindo o próprio objeto do script
            // Destroy(gameObject);
        }
    }
}
