using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeVsStart : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Executando Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Executando Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Tempo do Update: " + Time.deltaTime);
    }

    void FixedUpdate()
    {
        Debug.Log("Tempo do Fixed Update: " + Time.deltaTime);
    }
}
