using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegaObjeto : MonoBehaviour
{
    GameObject CAP;

    // Start is called before the first frame update
    void Start()
    {
        CAP = GameObject.FindWithTag("Cap");
        Destroy(CAP,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
