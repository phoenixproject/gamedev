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
na Unity inicia. Em outras palavras ela executa sempre que seu objeto é carregado
na cena.

### Método Awake

Esse método executa apenas uma vez na inicialização assim como o método Start, porém 
ele executa antes do Start e também executa mesmo o script de execução ter sido desabilitado
dentro da Unity.

### Método Update

Este método executa a todo momento como se estivesse dentro de um loop.
Conceitualmente um jogo roda em um loop infinito até que seja dado a ordem
para que ele termine. Portanto este método segue essa mesma linha de raciocínio
pois só finaliza quando o jogo é finalizado.
O método Update executa a cada milisegundo, em outras palavras ela executa a cada frame.
Situações como detecção de tecla pressionada devem ser feitas nesse método porque
não exigem tanto processamento já que o método tem um tempo de execução variável.

### Método LateUpdate

A diferença entre este método e o Update é que este sempre executa após do método Update.
Códigos como os de câmera seguindo o jogador logo após a movimentação realizada dentro do
método Update devem ser feitas dentro deste método.

### Método FixedUpdate

Este método executa do mesmo modo que o Update com a única diferença que enquanto o método
Update com o passar do tempo vai variando o tempo de duração de sua execução, o FixedUpdate
sempre executa com a mesma duração de tempo. 
Efeitos de física, de renderização, movimentação de personagem, colisão, de iluminação 
ou algum outro trabalho que requer muito processamento da Unity devem ser executados 
dentro deste método.
Segue um exemplo abaixo para ser visto no console.

```csharp
	// Update is called once per frame
	void Update()
	{
		Debug.Log("Tempo do Update: " + Time.deltaTime);
	}

	void FixedUpdate()
	{
		Debug.Log("Tempo do Fixed Update: " + Time.deltaTime);
	}
```

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
	Rigidbody rigidbodyJogador;

	// Start is called before the first frame update
	void Start()
	{
		rigidbodyJogador = GetComponent<Rigidbody>();
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
	Rigidbody rigidbodyJogador;
	float velocidade = 10f;

	// Start is called before the first frame update
	void Start()
	{
		rigidbodyJogador = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Start()
	{
		rigidbodyJogador.AddForce(new Vector3(0, 0, 1) * velocidade);
	}
```

### Detectando o teclado do usuário

Sempre que for necessário ser feita uma detecção de ações do teclado isso
deverá ser feito dentro do método update.

### Input

Este método serve para detectar todos os tipos de entrada do usuário
na Unity. Seja por toque na tela, clique de mouse, teclado do teclado, joysticks
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

### Capturando o objeto pela Tag (FindWithTag)

Para capturar um (uns) objeto (objetos) pela sua __Tag__ deve se utilizar a função FindWithTag.
No exemplo abaixo o destruímos logo após o capturarmos.

```csharp
	GameObject CAP;

	// Start is called before the first frame update
	void Start()
	{
		CAP = GameObject.FindWithTag("Cap");
		Destroy(CAP,5f);
	}
```


### Destroy(GameObject gameObject) (método para destruir um objeto)

A sintaxe é basicamente como está abaixo, a função Destroy remove o 
objeto da memória do programa.

```csharp    
	// Instanciando um novo GameObject
	GameObject gameObject = new GameObject();

	// Destruindo esse objeto GameObject 
	Destroy(gameObject);
```

Destruindo um objeto instanciado após ter presisonado uma tecla.

```csharp
	public GameObject obj;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.D))
		{
			// Destruindo objeto
			Destroy(obj);            
		}
	}
```

Destruindo um objeto instanciado após 5 segundos e ter presisonado uma tecla.

```csharp
	public GameObject obj;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.D))
		{
			// Destruindo objeto com intervalo de tempo (5 segundos)
			Destroy(obj,5f);
		}
	}
```

Destruindo o próprio objeto relacionado ao script após ter presisonado uma tecla.

```csharp
	public GameObject obj;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.D))
		{
			// Auto destruindo o próprio objeto do script
			Destroy(gameObject);
		}
	}
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

### Adicionando Componentes a Objetos (AddComponent)

Para adicionar componentes aos objetos dinanicamente é possível usando a função **AddComponent**.

```csharp    
	private void OnCollisionEnter(Collision objetocolidido)
	{
		if (Input.GetKeyDown(KeyCode.G))
		{
			gameObject.AddComponent<Rigidbody>();
		}
	}
```

### Seguindo um objeto com a câmera (Look at)

### Interpolação Linear

Interpolação linear é basicamente a alteração da intensidade da luz de forma gradativa.

```csharp    
	Light luz;

	// Start is called before the first frame update
	void Start()
	{
		luz = GetComponent<Light>();
	}

	// Update is called once per frame
	void Update()
	{
		// A função Mathf.Lerp espera valores:
		// inicial, final e de decrésimo
		// No caso abaixo a intensidade atual da luz como valor inicial,
		// o 0f (em float) é até onde esperamos que ela chegue e
		// o valor 0.005f é alterado a cada milisegundo.
		//luz.intensity = Mathf.Lerp(luz.intensity, 0f, 0.005f);
		luz.intensity = Mathf.Lerp(luz.intensity, 0f, Time.deltaTime);
	}
```
### Gerar objetos (Instatiate)

A função deste método é basicamente fazer com que com que objetos
possam ser instanciados em massa a partir de um modelo (um prefab por exemplo).
No exemplo abaixo podemos vver que a função Instantiate é chamada utilizando
o parâmetro **Vector3** que possui os parâmetros de localização tridimensional no
cenário (eixos x, y e z) e que tem direta ligação com o componente __Transform__
de cada objeto pois este componente é responsável para determinar a localização
dos objetos.
Adiante tem um valor no parâmetro da função chamado de **Quaternion.identity**
que quer dizer que o objeto criado não irá ser rotacionado, ou seja, não irá
ficar rodando entre si no mesmo mesmo eixo como é padrão da função __Vector3__
caso esse parâmetro não seja adicionado.

```csharp
	public GameObject objeto;
	float z = 1f;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			Instantiate(objeto, new Vector3(0f, 0f, z), Quaternion.identity);
			z += 1f;
		}
	}
```

Isso pode ser usado para fazer surgir vários itens ou personagens na tela.

### Função para executar funçõe (Invoke e InvokeRepeating)

A função **Invoke** pode ser chamada para invocar um método
de forma tardia da forma abaixo.

```csharp    
	public GameObject objeto;	
	float z = 1f;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			Invoke("GerarObjeto", 2f);
		}
	}
```
Ou também pode ser usada a função **InvokeRepeating**
que permite além de invocar um método definir a partir
de qual tempo (segundos no caso abaixo) deverá ser executado
e o último parâmetro e quantas vezes ela deverá ser repetida.

```csharp
	public GameObject objeto;
	float z = 1f;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		InvokeRepeating("GerarObjeto", 7f, 70f);
	}

	void GerarObjeto()
	{
		Instantiate(objeto, new Vector3(z, z, z), Quaternion.identity);
		z += 1f;
	}
```

### Criando menus interativos com Enum

Enums são basicamente um array de valores pré determinados e imutáveis
em que podemos consultar e a partir deles executar determinada ação.

No exemplo abaixo um **Enum** é criado com os valores baixo, medio e alto
e em seguida na condicional **if** esses valores são alterados a partir
da escolha de determinado **Enum** em modo gráfico.

```csharp
	public enum Lumininosidade { baixo, medio, alto };
	public Lumininosidade nivelDeIntensidade;
	Light luz;

	// Start is called before the first frame update
	void Start()
	{
		luz = GetComponent<Light>();

		if(nivelDeIntensidade == Lumininosidade.baixo)
		{
			// Debug.Log("Baixo");
			luz.intensity = 0.2f;
		}
		else
			if (nivelDeIntensidade == Lumininosidade.medio)
			{
				// Debug.Log("Médio");
				luz.intensity = 0.7f;
			}
			else
			{
				// Debug.Log("Alto");
				luz.intensity = 1.2f;
			}
	}
```

### Criando Rotinas

As rotinas são representadas quando declaramos um método do tipo **IEnumerator**.
A partir da criação do mesmo é definido na linha abaixo a partir de quando
a ação dentro desse método deverá ser executada (no caso abaixo a adição
do valor da variável após 2 segundos).

```csharp
	yield return new WaitForSeconds(2.0f);
	variavelDeTeste = !variavelDeTeste;
```

A ação dentro desse método também pode ser executada antes do intervalo de
2 segundos. Então seria executada e depois aguardado 2 segundos.

```csharp	
	variavelDeTeste = !variavelDeTeste;
	yield return new WaitForSeconds(2.0f);
```

Para chamar a rotina (**Couroutine**) utilizamos a sintaxe abaixo.

```csharp
	StartCoroutine("RotinaDeTeste");
```

No fim a rotina completa ficará desta forma:

```csharp
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
```

### Character Controller

Componente responsável pela movimentação de um personagem.
Usado também para movimentação em determinada direção como no 
exemplo abaixo:

```csharp
    private CharacterController ControllerObjeto;
    public float velocidade = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        ControllerObjeto = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Os parâmetros abaixo querem dizer:
        // Uma casa da Unity (Vector3.forward) vezes a velocidade (10) por segundo (Time.deltaTime).
        // Em outras palavras está se movimentando a 10 casas por segundo.
        ControllerObjeto.Move(Vector3.forward * velocidade * Time.deltaTime);
    }
```

### Time.deltaTime

É o tempo entre a execução de uma função para outra. É um intervalo de tempo de execução.

### Audio Source

### Tipos de Toque no Android

- Began :
- Move
- Stationary
- Ended
- Cancelled

### Considerações Úteis e Importantes

- Toda a vez em que uma variável dentro de um script C# for declarada como pública automaticamente
ela será exibida no componente __Script__ dentro da Unity e lá também pode ter seu valor alterado
(além de dentro do script).
- Toda a vez em que for declarado dentro do script algum componente que seja nativo da Unity (Rigidbody,
Rigidbody2D, Transform, etc) para que determinado componente do objeto seja referenciado dentro do script
é preciso além de deixá-lo como modificador **public** arrastar o componente desejado para dentro da variável
escolhida no componente __Script__ na Unity (não no Visual Studio).
- Se após ter criado um script precisar renomeá-lo após ter sido salvo, não faça isso. Apague o 
script, crie um novo com o nome correto porque insconsistências podem acontecer na Unity. Isso também
pode valer para a criação de objetos e componentes (não sei ao certo).
- Para acessar variáveis do tipo private nos scripts é preciso ativar o modo **Debug** da Unity. Para isso
Vá no canto superior direito da tela e logo abaixo de onde está ativado o modo para mudança de __Layout__
e ao lado direito de onde está desenhado um cadeado, clique no simbolo da lista à sua direita e acesse o menu abaixo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_SON/__MEDIA/01_son_debug_mode.PNG?raw=true "Debug Mode")