using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // A propriedade velocidade do componente Rigidbody 2D da Unity recebe a posição horizontal e vertical
        // do objeto multiplicado pela velocidade declarada dentro do Visual Studio e inicializada do lado de fora
        // na Unity.
        theRB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * moveSpeed);
    }
}
