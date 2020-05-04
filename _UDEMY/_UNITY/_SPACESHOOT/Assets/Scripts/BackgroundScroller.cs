using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Atributos responsáveis pelos backgrounds do game
    public Transform BG1, BG2;

    // Atributo responsável pela velocidade que o background anda
    public float scrollSpeed;

    // Atributo responsável por obter a largura de um background
    private float bgWidth;

    // Start is called before the first frame update
    void Start()
    {
        // Para obter a largura do primeiro background tem 
        // que obter o tamanho dos limites do eixo X do sprite contido
        // no componente SpriteRenderer
        bgWidth = BG1.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {       
        BG1.position = new Vector3(BG1.position.x - (scrollSpeed * Time.deltaTime), BG1.position.y, BG2.position.z);
        BG2.position -= new Vector3(scrollSpeed * Time.deltaTime, 0f, 0f);

        if(BG1.position.x < -bgWidth - 1)
        {
            BG1.position += new Vector3(bgWidth * 2f, 0f, 0f);
        }

        if (BG2.position.x < -bgWidth - 1)
        {
            BG2.position += new Vector3(bgWidth * 2f, 0f, 0f);
        }
    }
}
