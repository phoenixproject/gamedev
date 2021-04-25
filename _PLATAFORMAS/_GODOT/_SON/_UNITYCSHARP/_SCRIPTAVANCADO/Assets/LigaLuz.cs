using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigaLuz : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            luz.enabled = !luz.enabled;
        }
    }
}
