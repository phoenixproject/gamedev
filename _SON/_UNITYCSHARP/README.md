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

- GameObject : serve para guardar (todos os tipos de) objetos da Unity.
- Rigidbody : serve (quando declarado no código) para capturar o componente
Rigidbody do objeto a que pertence o script. 
O componente Rigidbody do objeto é obtido a partir do momento em que a 
função GetComponent é chamada (como no código abaixo). Após isso
será possível manipular esse componente do objeto em questão.

```csharp
    Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
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

### Movimentando