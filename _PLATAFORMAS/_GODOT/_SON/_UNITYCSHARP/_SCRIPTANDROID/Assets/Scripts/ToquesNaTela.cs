using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToquesNaTela : MonoBehaviour
{
    int toquesQtd = 0;
    public Text texto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        toquesQtd += Input.touchCount;
        texto.text = toquesQtd.ToString();
    }
}
