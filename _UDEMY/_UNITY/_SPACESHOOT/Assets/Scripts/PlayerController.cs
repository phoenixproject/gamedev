using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;

    public Transform bottomLeftLimit, topRightLimit;

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
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        // Toda a vez que precisamos acessar/capturar a posição de um objeto utilizamos o componente (já instanciado)
        // transform e seu atributo position.
        // A partir do momento me que a posição do objeto (transform.position) recebe um novo obejto do tipo Vector3
        // o mesmo espera 3 parâmetros de posições espaciais de entrada porque se trata de um componente que trabalha 
        // com posicionamento tridimensional (x, y e z). Contudo para que nosso objeto trafegue no espaço 2D dentro de
        // uma certa limitação de espaço utilizamos a função Mathf.Clamp que estabelece restrição de movimento a partir
        // de 3 parâmetros: a posição referencial (de onde o objeto está), a posição limite em determinado eixo e outra
        // posição em determinado eixo.
        // No caso abaixo para cada parâmetro de entrada do objeto Vector3 (x, y e z) estabelecemos também um parâmetro
        // a partir da restrição de cada um em seus eixos: x, y e z. No caso do eixo z (profundidade) como estamos 
        // trabalhando especificamente com objetos 2D não há necessidade de restrição de movimento porque não se trabalha
        // com este eixo e aí o que vale é posição z natural do objeto transform.
        // Lembrando que os objetos bottomLeftLimit e topRightLimit já tiveram seus valores iniciais no componente Transform
        // alterados na Unity para poderem servir como limitadores nos parâmetros dos métodos abaixo.
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.position.x, topRightLimit.position.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.position.y, topRightLimit.position.y), transform.position.z);
    }
}
