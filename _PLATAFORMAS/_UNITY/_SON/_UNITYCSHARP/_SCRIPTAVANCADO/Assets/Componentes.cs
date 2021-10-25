using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes : MonoBehaviour
{
    Light luz;

    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        luz.intensity -= 0.0005f;
    }
}
