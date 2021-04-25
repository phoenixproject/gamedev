using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotina : MonoBehaviour
{
    public bool variavelDeTeste;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("RotinaDeTeste");
    }

    IEnumerator RotinaDeTeste()
    {
        yield return new WaitForSeconds(2.0f);
        variavelDeTeste = !variavelDeTeste;
    }
}
