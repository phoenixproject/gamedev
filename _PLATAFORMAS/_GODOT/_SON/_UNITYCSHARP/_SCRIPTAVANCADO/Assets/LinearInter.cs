using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInter : MonoBehaviour
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
        // A função Mathf.Lerp espera valores:
        // inicial, final e de decrésimo
        // No caso abaixo a intensidade atual da luz como valor inicial,
        // o 0f (em float) é até onde esperamos que ela chegue e
        // o valor 0.005f é alterado a cada milisegundo.
        //luz.intensity = Mathf.Lerp(luz.intensity, 0f, 0.005f);
        luz.intensity = Mathf.Lerp(luz.intensity, 0f, Time.deltaTime);
    }
}
