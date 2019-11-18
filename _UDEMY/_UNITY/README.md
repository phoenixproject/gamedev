###### [Sintaxe básica de escrita e formatação no GitHub](https://help.github.com/pt/github/writing-on-github/basic-writing-and-formatting-syntax)<br/>

## Projeto Space Shoot - Projeto 2D (Unity versão: 2019.2.11f1)

### Layout utilizado na Unity

Window > Layout > 2 by 3


### Aspecto pixelado

Para dar um aspecto pixelado ao bitmap importado como asset,
dentro de **Import Settings** (exibido no __Inspector__ ao selecionarmos
um objeto) podemos alterar o valor do atributo **Pixels Per Unit** para
**48**, em **Filter Mode** colocamos o valor **Point (no filter)** e dentro
da área **Defaut** alteramos o valor **Max Size** para **64** e em 
**Compression** deixamaremos o valor como **None**.

### Criando um objeto para receber um sprite

Para criarmos um objeto que nos permita utilizá-lo na cena ( __Scene__ ) como
sprite 2d devemos seguir no menu  __Game__ __Object__ > __2D__ __Object__ > __Sprite__ . 

### Rigidbody 2D

Todos os objetos na Unity são estáticos por si só. Eles não interagem uns com os outros.
E para que essa interação aconteça ao selecionar um objeto, na aba Inspector adicionamos
um componente de nome Rigibody. Esse componente é reponsável por dar vida ao objeto tornando-o
interativo. E a partir desse momento o objeto começa reagir a física, começa a se movimentar, etc.
Ele basicamente aplica os efeitos de físicas que temos na vida real para o objeto, fazendo inclusive
que outros objetos passem a colidir (ter efeitos de colisão) com estes objetos que possuam a
propriedade Rigibody. Em suma, Rigibody é um component que adiciona propriedades físicas ao objeto.
E exclusivamente quando utilizarmos objetos 2D devemos utilizar o componente __Rigidbody__ __2D__ 
e não apenas o __Rigidbody__ que é utilizado em objetos **3D**.

### Gravidade

Dentro do componente __Rigidbody__ __2D__ logo de início quando temos um __Game__ __Object__ do tipo
__Sprite__ adicionado é recomendável alterar o valor do atributo **Gravity** **Scale** para **0**
porque como o componente contém toda a física do objeto ao pressionar o botão Play da Unity o mesmo
já inicia caindo no cenário.

### Criando objetos vazios

Para criar objetos vazios clique com o botão direito dentro de sua __Sample__ __Scene__ e no menu
que se abrirá escolhe **Create Empty**. Lembrando que um objeto (vazio ou não) por padrão sempre
traz consigo o componente Transform que é responsável por representar sua localização e sua forma
na cena. Esse componente pode ser alterado através de um script C# através das funções **Vector3**
e **Vector2**.

### Delimitando área de movimentação para um objeto 2D

Toda a vez que precisamos acessar/capturar a posição de um objeto utilizamos o componente (já instanciado)
transform e seu atributo position. A partir do momento me que a posição do objeto (transform.position) 
recebe um novo obejto do tipo Vector3 o mesmo espera 3 parâmetros de posições espaciais de entrada porque 
se trata de um componente que trabalha com posicionamento tridimensional (x, y e z). 
Contudo para que nosso objeto trafegue no espaço 2D dentro de uma certa limitação de espaço utilizamos 
a função Mathf.Clamp que estabelece restrição de movimento a partir de 3 parâmetros: a posição referencial 
(de onde o objeto está), a posição limite em determinado eixo e outra posição em determinado eixo.

No caso do código abaixo para cada parâmetro de entrada do objeto Vector3 (x, y e z) estabelecemos também um parâmetro
a partir da restrição de cada um em seus eixos: x, y e z. No caso do eixo z (profundidade) como estamos 
trabalhando especificamente com objetos 2D não há necessidade de restrição de movimento porque não se trabalha 
com este eixo e aí o que vale é posição z natural do objeto transform.

Lembrando que os objetos bottomLeftLimit e topRightLimit já tiveram seus valores iniciais no componente Transform
alterados na Unity para poderem servir como limitadores nos parâmetros dos métodos abaixo ( _bottomLeftLimit_ teve
seu componente __Transform__ alterado para que sua posição inicial permaneça no canto inferior esquerdo 
da área delimitada pelo objeto **MainCamera**, bem como o _topRightLimit_ teve sua posição inicial alterada para
permanecer no canto superior direito da área delimitada pelo objeto **MainCamera**.

```csharp
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
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.position.x, topRightLimit.position.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.position.y, topRightLimit.position.y), transform.position.z);
	}
```

### Add Background 

Ao arrastar um arquivo .png (por exemplo) para a cena podemos na Unity alinhá-lo em relação a outros objetos.

Ao arrastarmos esse arquivo no componente chamado __Sprite__ __Renderer__, mais precisamento em _Additional_ _Settings_,
podemos alterar a ordem em que os objetos ficam um por cima (ou por baixo) dos outros alterarando o atributo
**Order in Layer**. Nesse caso se colocamos se colocamos o número 0 (por exemplo) neste componente deste objeto,
podemos inserir o número 1 em outro __Sprite__ __Renderer__ de outro objeto para que ele se sobreponha a 
ao objeto anterior ou -1 para que este fique abaixo do objeto anterior. Para que não tenha efeito todos os objetos
deverão estar com o valor 0; 

Outra opção existente e mais recomendada é utilizar-se do atributo **Sorting Layer** que permite que sejam 
criados nomes para as layers e ordenados, sendo que quanto mais acima o layer estiver, mais por trás dos
objetos da cena ele estará e quanto mais abaixo, mais acima estará dos objetos da cena. É preciso também
após criados os layers, identificá-los nos objetos desejados.

Os layers ficarão ordenados como na figura abaixo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/01_space_shooting_layers.PNG?raw=true "Sorting Layer")

### Scrolling the Background / Bitmap Snap / Background Câmera / Background Holder

- Para expandir uma área de background: arraste um bitmap (jpeg, png) para dentro da cena e se preferir arraste outros
backgrounds em frente aos outros (duplicando o bitmap existente sempre que precisar colocar um mais a frente). Lembrando
que quando for colocar o outro a sua frente uma regra básica para que dois bitmaps fiquem juntos é: 
  - Selecione o bitmap 2 (BG2) na aba __Hierarchy__;
  - Selecione a aba __Scene__;
  - Pressione a tecla **V** no teclado na borda superior à esquerda do bitmap 2 para selecioná-la (com a ferramenta 
  **Move Tool** selecionada);
  - Mantendo a tecla **V** pressionada arraste com o mouse para a esquerda em direção ao bitmap 1 (BG1) que o **Snap** entre
  as figuras será realizado como na figura abaixo.

  ![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/02_space_shooting_background_snap.png?raw=true "Background Snap")

- É aconselhável alterar o background da câmera com a cor de fundo do background utilizado no fundo da cena
no intuito de não causar uma impressão bruta na área em que os dois fazem divisa.
- Para que os backgrounds não fiquem desorganizados na aba **Hierarchy** deve-se criar um objeto vazio (como será para suporte à backgrounds
o chamaremos de _BG_ _Holder_) e em seu componente __Transform__ alterar todos os valores de x, y e z do atributo **Position** para 0 
e arrastar os dois backgrounds ( _BG1_ e _BG2_) para dentro dele.
- Notadamente podemos inserir vários backgrounds um atrás do outro, mas não é este o caso aqui. Nessa situação teremos
apenas 2 backgrounds e a câmera irá percorrê-los até chegar ao final do segundo para aí então retornar ao início
do 1º background e fazer isso sucessivamente dando o aspecto de continuidade. O procedimento começa na criação de um
script C# e lá declarando duas variáveis públicas do tipo __Transform__ que representarão os 2 backgrounds. Em seguida devemos arrastar
este script para dentro do objeto _BG_ _Holder_. Feito isso também devemos arrastar cada background contido dentro do objeto _BG_ _Holder_ 
( _BG1_ e _BG2_) para dentro de cada variável pública que representa os objetos, respectivamente. O resumo fica descrito no script abaixo.

```csharp
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
```
- Lembrando que é possível reproduzir esse cenário clonando o objeto _BG_ _Holder_ e apenas alterando seus arquivos de backgrounds. E para 
dar um efeito de parallax é só alterar (na Unity) o valor da variável scrollSpeed.

### Adding Depth & Moving Objects

A ideia é movimentar objetos assim como os backgrounds