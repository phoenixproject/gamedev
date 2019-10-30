###### [Sintaxe básica de escrita e formatação no GitHub](https://help.github.com/pt/github/writing-on-github/basic-writing-and-formatting-syntax)<br/>

# son
School of Net

### Adicionando scripts C# nos projetos e aos objetos

Para criar um script C# deve-se clicar com o botão direito dentro de um diretório (pasta Assets por exemplo)
na hierarquia de Project e escolher Create > C# Script. E em seguida para adicionar o script ao objeto
basta clicar, segurar e arrastar este script para dentro do objeto desejado.

### Definições de um scritpt da Unity dentro do Visual Studio

- using UnityEngine : é o namespace padrão da Unity que está sendo importado para
ser usado no Visual Studio.

- Inicialmente todo script padrão da Unity são compostos por no mínimo
dois métodos que são eles: Start() e Update(). Essas são basicamente
suas principais funções.

### Método Start

Esse método executa apenas uma vez, ou seja, sempre que a aplicação feita
na Unity inicia.

### Método Update

Este método executa a todo momento como se estivesse dentro de um loop.
Conceitualmente um jogo roda em um loop infinito até que seja dado a ordem
para que ele termine. Portanto este método segue essa mesma linha de raciocínio
pois só finaliza quando o jogo é finalizado.
O método Update executa a cada milisegundo.

### Método Debug

Eventualmente usaremos a função Debug.Log("Alguma mensagem") para podermos
rastrear dentro do console da Unity o que está acontecendo no nosso jogo.

### Tipos de Váriaveis da Unity

- __GameObject__ : serve para guardar (todos os tipos de) objetos da Unity.
- __Rigidbody__ : serve (quando declarado no código) para capturar o componente
__Rigidbody__ do objeto a que pertence o script. 
O componente __Rigidbody__ do objeto é obtido a partir do momento em que a 
função GetComponent é chamada (como no código abaixo). Após isso
será possível manipular esse componente do objeto em questão.

```csharp
    __Rigidbody__ __Rigidbody__;
    
    // Start is called before the first frame update
    void Start()
    {
        __Rigidbody__ = GetComponent<__Rigidbody__>();
    }
```

### Movimentando um objeto com o função AddForce

Após ter capturado o componente __Rigidbody__ de um objeto é possível
movimentá-lo fisicamente com o método AddForce.
Invocado pelo componente __Rigidbody__ quando tratamos de ambiente 3d
devemos informar três parâmetros para um novo objeto Vector3 (que é 
utilizado como parâmetro de entrada da função AddForce.
Estes três parâmetros são basicamente os eixos X, Y e Z correspondentes
a posição do componente __Transform__ pertencente ao objeto a que o script
se refere. No exemplo abaixo foi inserida uma variável de nome velocidade
que multiplicará cada um do eixos individualamente.

```csharp
    __Rigidbody__ __Rigidbody__;
	float velocidade = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        __Rigidbody__ = GetComponent<__Rigidbody__>();
    }
	
	// Update is called once per frame
    void Start()
    {
        __Rigidbody__.AddForce(new Vector3(0,0,1) * velocidade);
    }
```

### Detectando o teclado do usuário

Sempre que for necessário ser feita uma detecção de ações do teclado isso
deverá ser feito dentro do método update.

### Input

Este método serve para detectar todos os tipos de entrada do usuário
na Unity. Seja por toque na tela, clique de mouse, teclado do teclado
e etc, qualquer forma de interação do usuário com o a Unity.

#### Input.GetKey() 
 
É uma função que serve para detectar qual tecla o usuário está pressionando
no teclado.
Geralmente executamos essa função recebendo de parâmetro de entrada a função
KeyCode.NOME_CORRESPONDENTE_DA_TECLA que por sua vez envia para a função 
Input.GetKey() o código da tecla do teclado e faz com que a mesma retorne
true caso identifique que a tecla esteja pressionada e false caso não esteja.
Esse método tem que ser executado dentro da função Update();

#### Detectando o clique do mouse

Para fazer isso utilizamos a função GetMouseButton() recebendo
como parâmetro de entrada um determinado código que identifica alguma função
do mouse.

Exemplos: 
 
  - 0 Botão Esquerdo
  - 1 Botão Direito
  - 2 Botão do Meio
  
Para obtermos o retorno em que momento como o mouse interagiu com o game
utilizamos a função GetMouseButton(CÓDIGO_DA_FUNCAO_DO_MOUSE).

E por fim a função é executada dessa forma: Input.GetMouseButton(0);

Porém a função acima executa enquanto o botão do mouse estiver pressionado,
ou seja, se ele estiver sendo executado dentro do método Update que executa
a cada milisegundo essa detectação não será feita apenas uma vez, mas várias
vezes enquanto a pessoa pressiona o mouse apenas uma vez. 

Portanto parar corrigir a situação acima caso precise obter apenas o momento
em que o mouse é clicado (e não que permanece) utiliza-se a função: Input.GetMouseButtonDown(0);

### Rotacionando objetos (Rotate)

O componente __Transform__ assim como o __Rigidbody__ permitem que seja possível
rotacionar um objeto. 
Uma observação é que quando o script está atrelado ao objeto não é 
preciso chamar a função GetComponent pois __somente_ o componente __Transform__ é um componente
fixo, ou seja, a grosso modo seria uma espécie de variável global do objeto (não necessariamente esta
é a definição correta).
Assim como é feita a movimentação do objeto com a função AddForce, para rotacionar objetos
usando o componente __Transform__ também é necessário receber como atributo um objeto do tipo
Vector3.

```csharp
    
	float velocidadeRotacao = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	// Update is called once per frame
    void Start()
    {
        transform.Rotate(new Vector3(1, 1, 1) * velocidadeRotacao);
    }
```

### Adicionando Tag ao objeto

Quando uma __Tag__ é adicionada a um objeto entende-se que a mesma funciona como uma espécie de "id" para
este objeto no qual será utilizado para identificá-la ou melhor dizendo é uma forma para organizar objetos
em grupos.
Esta __Tag__ pode ser acessada pelo objeto pelo atributo **name** dentro da propriedade __Transform__ contida
no objeto.

### Destroy(GameObject gameObject) (método para destruir um objeto)

A sintaxe é basicamente como está abaixo, a função Destroy remove o 
objeto da memória do programa.

```csharp
    
	// Instanciando um novo GameObject
	GameObject gameObject = new GameObject();
	
	// Destruindo o objeto GameObject
	Destroy(gameObject);
```

### Método OnCollisionEnter (Detectando colisões no objeto)

Quando implementamos o método OnCollisionEnter o parâmetro recebido em sua assinatura
remete ao objeto que foi colidido durante a execução do game.
No exemplo abaixo a partir de uma comparação de nome de __Tag__ é chamada a função Destroy para que
o objeto que foi colidido seja destruído com a função Destroy. 
 
```csharp
    
	private void OnCollisionEnter(Collision objetocolidido)
    {
        if (objetocolidido.transform.CompareTag("Pontos"))
        {
            Destroy(objetocolidido.gameObject);
        }
    }
```

### Transformando objetos em Prefabs

Para transformar um objeto num __Prefab__ basta arrastá-lo da área de __Hierarchy__ para dentro
da área de __Assets__. A partir do momento que se torna um __Prefab__ o objeto pode ser espalhado
pelo jogo como se fosse apenas um "clone" de seu original pois não importam quantas cópias desse
__Prefab__ existirem todos terão o mesmo tipo de comportamento do objeto que deu origem. Inclusive
se forem referenciados por __Tag__ fica mais simples para interagir com eles.

### Acessando variáveis

Quando deixamos as variáveis dentro dos scripts com o modificador de acesso **public**
as mesmas passam a ser acessíveis e podem ser modificadas dentro da Unity.

### Audio Source