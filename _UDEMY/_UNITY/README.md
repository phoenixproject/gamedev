###### [Sintaxe básica de escrita e formatação no GitHub](https://help.github.com/pt/github/writing-on-github/basic-writing-and-formatting-syntax)<br/>

## Projeto Space Shoot - Projeto 2D (Unity versão: 2019.2.11f1)

### Layout utilizado na Unity

Window > Layout > 2 by 3

#### The Player & Backgrounds

### Aspecto pixelado

Para dar um aspecto pixelado ao bitmap importado como asset,
dentro de **Import Settings** (exibido no __Inspector__ ao selecionarmos
um objeto) podemos alterar o valor do atributo **Pixels Per Unit** para
**48**, em **Filter Mode** colocamos o valor **Point (no filter)** e dentro
da área **Defaut** alteramos o valor **Max Size** para **64** e em 
**Compression** deixamaremos o valor como **None**.

### Criando um objeto para receber um sprite

Para criarmos um objeto que nos permita utilizá-lo na cena ( __Scene__ ) como
sprite 2d devemos seguir no menu  **Game Object** > **2D Object** > **Sprite** . 

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

### Delimitando área de movimentação para um objeto 2D (Keep the Player on Screen)

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

A ideia é movimentar objetos assim como os backgrounds pode ser aplicada de forma similar a de cima usando o script abaixo.

```csharp
	public float moveSpeed;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
```

Após adicionado o script ao objeto desejado basta alterar o valor da variável moveSpeed como desejado.

Vale ressaltar que a função __OnBecameInvisible()_ permite que se insira algum tipo de código aí dentro
que possa ser executado quando o objeto não mais está vísivel na tela.

### Making Solid Meteors

Para adicionar objetos que apenas colidam com outros sprites (digo aqui sprites colidindo com sprites) devemos
adicionar o componente __Box__ __Collider__ __2D__ em cada componente que deseja criar colisão. E para que 
o objeto que colidiu não ficar girando é preciso ir até o atributo **Constraints** do componente __Rigidbody2D__
e marcar o valor _Z_ do parâmetro **Freeze Rotation**.

#### Shots and Explosions

### Creating a Laser Shot / Firing Shots 

Para que um objeto cause uma destruição de outro objeto após uma colisão é preciso que o componente
__Rigidbody2D__ (adicionado ao objeto) que vai destruir outro esteja com o atributo __Body__ __Type__ marcado como **Kinematic**.
Bem como o componente __Box__ __Collider__ __2D__ também tenha sido adicionado com o atributo **Is** **Trigger** marcado.

O script abaixo é utilizado no mesmo objeto

```csharp
	public float shotSpeed = 7f;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += new Vector3(shotSpeed * Time.deltaTime, 0f, 0f);
	}

	private void OnTriggerEnter2D(Collider2D outroobjeto)
	{
		Destroy(this.gameObject);
	}

	private void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
```

Feito isso podemos tornar este objeto um __Prefab__.
Lembrando que toda a alteração feita no _prefab_ de um objeto ao selecionar o objeto
que originou esse _prefab_, dentro da aba __Inspector__ pode ser acionada a opção **Override**
para que as alterações feitas no _prefab_ possam ser implementadas também no objeto original,
que inclusive pode ser excluído em seguida.

Seguindo no menu __Edit_ e opção __Project__ __Settings__ > __Input__ > __Axes__ > __Fire1__, 
alterar o valor do atributo **Positive** **Button** para **j**.

Acrescentando os atributos _shotPoint_ e _shot_ e inserindo o tratamento para capturar o evento
do botão qeu que simboliza a ação de atirar ( __Fire1__ ) e instanciando um novo objeto **shot**
e o alocando nos eixo do objeto do tipo __Transform__, **shotPoint**.

Tudo isso partindo do princípio de que dentro do objeto __Player__ contido em __Hierarchy__ foi
criado um objeto vazio de nome __Fire__ __Point__ responsável para lançar o tiro (shot) da nave.

```csharp
	public float moveSpeed;
	public Rigidbody2D theRB;

	public Transform bottomLeftLimit, topRightLimit;

	public Transform shotPoint { get; set; }
	public GameObject shot { get; set; }

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

		// Toda a vez em que for presisonado a tecla correspondente ao "Fire" (tiro) será instanciado um novo objeto
        // do tipo GameObject e terá sua posição de acordo com o objeto do tipo Transform correspondente.
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(shot, shotPoint.position, shotPoint.rotation);
        }
	}
```

Após realizada a alteração no script acima deve-se arrastar o objeto __Fire__ __Point__ para dentro do atributo público **Shot Point** 
e o __Prefab__ **PlayerShot** para dentro do atributo público **Shot**. Ambos contidos no script **PlayerController** anexado ao objeto
__Player__ pertencente a aba __Hierarchy__. Deve ficar como na figura abaixo. 

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/03_space_shooting_firing_shots.png?raw=true "Firing Shots")

Feito isso é possível pressionar o botão **Play**, movimentar a nave do jogador e ao apertar a tecla _J_ que o tiro é acionado. Ressaltando
que para alterar a posição do shot é preciso alterar a posição do objeto __Fire__ __Point__ com a ferramenta **Move Tool**, já que _prefab_
está associado a ele.

Adiante entraremos novamente em __Project__ __Settings__ e retirar os atributos que envolvem tanto o objeto __Player__ quanto __Player__ __Shot__
da secção __Physics__ __2D__ como no quadro abaixo porque estes _layers_ não devem interagir com os outros nessa secção.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/04_space_shooting_phisics_2d.png?raw=true "Physics 2D")

Prosseguindo, vale lembrar que o componente __Sprite__ __Renderer__ tanto do _prefab_ __PlayerShot__ quando dos _space_ _objects_ possui um
atributo **Sorting Layer** para que os mesmos sejam organizados.

Lembrando também que para adicionar um áudio ao objeto a um __Prefab__ basta arrastá-lo até o mesmo.

### Auto Firing

Para que o tiro da nave seja sempre disparado enquanto pressionado o botão de tiro é preciso entender que existe
uma diferença entre os métodos **Input.GetButtonDown** e **Input.GetButton** porque o primeiro executa apenas uma vez
apenas quando a tecla é pressionada e o segundo quando a tecla mantém-se pressionada.

É importante que exista uma variável que guarde o intervalo de tempo entre um tiro e outro ( _timeBetweenShots_) e 
que seja pública para que também possamos alterar seu valor dentro da Unity. Também é necessário que haja uma
variável _shotCounter_ 

```csharp
	public float timeBetweenShots = .1f;
    private float shotCounter;
```

Dentro do método __Update__ toda a vez em que for mantida pressionada a tecla correspondente ao "Fire" o 
tiro é instanciado enquanto a ação for verdadeira.

```csharp	
	if (Input.GetButton("Fire1"))
	{
		shotCounter -= Time.deltaTime;
		if(shotCounter <= 0)
		{
			Instantiate(shot, shotPoint.position, shotPoint.rotation);
			shotCounter = timeBetweenShots;
		}
	}
```

### Shot Impact Effects 

Para exibir efeitos é preciso fazer animações e estas depedem criarmos uma animação. Para isso
seguidos no Menu __Windows__ > __Animation__ > __Animation__ e em seguida na janela de animação
que se abrirá a arrastamos sua aba para junto das outras que já existem.
Em seguida expandimos algum __**Sprite 2D**__ em **Sprite Mode** do tipo _Multiple_ que o botão
**Create** na aba __Animation__ se abrirá. Logo após clique no botão **Create** para criar uma
nova animação e depois arraste para a linha do tempo os sprites que desejar como na figura abaixo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/05_space_shooting_animation.png?raw=true "Animation")

Adicione o keyframe no instante 1:30 como abaixo:

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/06_space_shooting_animation_keyframe.png?raw=true "Animation Keyframe")

E no instante 0:30 desligar o Sprite Renderer.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/07_space_shooting_animation_sprite_renderer_off.png?raw=true "Animation Sprite Renderer Off")

E por fim transformar essa animação em um __Prefab__, criar o script abaixo (de nome **DestroyOverTime**) e associar a esta animação e realizar um _Override_ no mesmo.

```csharp
	public float lifetime;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		Destroy(gameObject, lifetime);
	}
```

Abrir o script **PlayerShot**, adicionar o objeto **impactEffect** do tipo __GameObject__, acrescentar um Instantiate
do mesmo dentro do método __OnTriggerEnter2D__, abrir o __Prefab__ _impact effects_, adicionar a propriedade _Shots_
ao atributo **Sorting Layer** e alterar o valor de **Order in Layer** para _-1_ de seu componente __Sprite__ __Renderer__.

```csharp
	public float shotSpeed = 7f;
	public GameObject impactEffect;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += new Vector3(shotSpeed * Time.deltaTime, 0f, 0f);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(this.gameObject);
	}

	private void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
```

Em seguida abrir o __Prefab__ **PlayerShot** e no atributo **Impact Effect** do componente que carrega o script **Player Shot** adicionar
o __Prefab__ **impact effect** como feito abaixo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/08_space_shooting_impact_effects_on_player_shot.png?raw=true "Impact Effects on Player Shot")

### Destroying Meteors

Para destruir um objeto a partir do tiro criado basta construir uma tag (no nosso caso foi _Space_ _Object_ ) e em seguida colocar no 
script do tiro a condição para que a destruição desse objecto aconteça.

```csharp
	public float shotSpeed = 7f;
	public GameObject impactEffect;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += new Vector3(shotSpeed * Time.deltaTime, 0f, 0f);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Instantiate(impactEffect, transform.position, transform.rotation);

		if(other.tag == "Space Object")
		{
			Destroy(other.gameObject);
		}

		Destroy(this.gameObject);
	}

	private void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
```

### Particle Explosion Effect

Para criarmos efeitos de explosão devemos seguir em __GameObject__ > __Effects__ > __Particle__ __System__. Em seguida
ao deixar selecionado o objeto que foi criado seguimos para a aba __Inspector__ e dentro do componente __Particle__ __System__
alteraremos os valores nos seguintes atributos abaixo. Mas antes dentro de __Transform__ alteraremos o valor do atributo __Rotation__
em _x_ para 0;

- **Shape** > *Shape* > Circle;
- **Emission** > *Rate over Time* > 0;
- **Emission** > *Bursts* > *Clicar no sinal de + para adicionar um valor padrão*;
- **Duration** > *2.00*;
- **Start Lifetime** > _1.5_;
- **Start Speed** > 2;
- **Renderer** > _Material_ > Sprites-Default;
- **Renderer** > *Sorting Layer ID* > Shots;
- **Renderer** > *Order Layer* > -2;
- **Start Size** > Random Between Two Constants, 0.1, 0.2;
- **Start Color** > Random Between Two Colors, *Clicar nos campos para preencher as duas cores*; 
- **Size over Lifetime** > *Clicar para deixar marcado*;
- **Size over Lifetime** > *Size* > *Clicar para escolher a reta tombada para a esquerda no gráfico Particle System Curves*;
![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/09_space_shooting_size_over_lifetime.png?raw=true "Size over Lifetime")
- **Looping** > *Desmarcar* (pode pressionar Play no painel Particle Effect para testar o efeito);

- Agora clique em **Add Component**, adicinoar o script __Destroy__ __Over__ __Time__ e marcar sua proprieda pública como _1.75_;
- Insira um __GameObject__ chamado _objectExplosion_ no script __PlayerShot__ e o instancie onde o objeto da tag __Space Object__ é destruído
como no script abaixo:

```csharp
	public float shotSpeed = 7f;
	public GameObject impactEffect;

	public GameObject objectExplosion;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += new Vector3(shotSpeed * Time.deltaTime, 0f, 0f);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Instantiate(impactEffect, transform.position, transform.rotation);

		if(other.tag == "Space Object")
		{
			Instantiate(objectExplosion, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
		}

		Destroy(this.gameObject);
	}

	private void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
```

- E por fim abra o __Prefab__ e no atributo *Object Explosion* do script __PlayerShot__ arraste o __Prefab__ *Particle System* (aproveite e
renomeie-o para *Object Explosion Effect*);

### Health

### Player Health System

Para iniciarmos o processo de gerenciar o sangue, life, vidas do player é preciso criar um script **Health Manager**.

```csharp
// Utilizado dessa forma para implementação 
	// do padrão de projeto Singleton
	public static HealthManager instance;

	public int currentHealth;
	public int maxHealth;

	public GameObject deathEffect;

	private void Awake()
	{
		instance = this;
	}

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void HurtPlayer()
	{
		currentHealth--;

		if (currentHealth <= 0)
		{
			Instantiate(deathEffect, transform.position, transform.rotation);
			gameObject.SetActive(false);
		}
	}
```

No script acima o **gameObject** não está sendo destruído, mas sim ocultado. E para interagir com os 
asteróides do game deveremos criar um novo script chamado **HurtPlayer** como o que está abaixo. 

Lembrando que o objeto __Player__ contido em __Hierarchy__ deve a partir de agora ter sua **Tag** identificada
como _Player_ e o script acima (**Health Manager**) deve também ser adicionado a este objeto, bem como seu
atributo público **Max Health** ter seu valor alterado para 3.

Para o objeto __meteoro__ contido em __Hierarchy__ adicionamos a este o script **HurtPlayer**.

```csharp
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			HealthManager.instance.HurtPlayer();
		}
	}
```

### Making Enemies

- Primeiro devemos ter o sprite 2d que irá fazer o papel do inimigo;
- Acrescente um script chamado de **EnemyController** e acrescente o código abaixo;
```csharp
	public float moveSpeed;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
```
- Adicione o script acima ao objeto referente ao inimigo (**EnemyGreen** no caso);
- Altere o atributo **Move Speed** do script para valor 3;
- Adicione um componente do tipo __Box__ __Collider2D__ ao objeto **EnemyGreen** e clique
em _Edit Collider_ para diminuir a área de colisão do inimigo;
![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/10_space_shooting_making_enemies.png?raw=true "Making Enemies")
- Crie uma __Tag__ e um __Layer__ com o nome _Enemy_ e adicione ambos ao objeto;
- Arraste o script **HurtPlayer** para dentro do objeto **EnemyGreen**.

### Enemy Movement

- Faça as alteração no código do script **EnemyController** como se segue.
```csharp
	public float moveSpeed;

	public Vector2 startDirection;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
		transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
```
- Altere na Unity o atributo público **startDirection** dentro do componente script **EnemyController** no objeto **EnemyGreen** 
de _X_ para _-1_ e _Y_ para _0.25_.

### Better Movement

Para melhorar os movimentos do inimigo no script **EnemyController** devem constar as alterações do código abaixo.

```csharp
	public float moveSpeed;

	public Vector2 startDirection;

	public bool shouldChangeDirection;
	public float changeDirectionXPoint;
	public Vector2 changedDirection;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
		
		if (!shouldChangeDirection)
		{
			transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
		}
		else
		{
			if(transform.position.x > changeDirectionXPoint)
			{
				transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
			}
			else
			{
				transform.position += new Vector3(changedDirection.x * moveSpeed * Time.deltaTime, changedDirection.y * moveSpeed * Time.deltaTime, 0f);
			}
		}
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
```

Algumas variável foram acrescentadas e a rotina de atualização modificada. Para tanto na Unity devemos alterar os atributos
públicos contidos no componente que carrega o script **EnemyController** para deixar _marcado_ **Should Change Direction**
e em **Change Direction** para _-0.75_ em _X_ e _-0.5_ em _Y_.

### Creating Enemy Shot

- Para criar um tiro feito pelo inimigo é preciso obter um sprite 2d para representá-lo. Feito isso adicione um componente do
tipo **BoxCollider2d** a ele e marque seu atributo _Is_ _Trigger_, crie um script chamado **EnemyShot** e adicione o código abaixo.

```csharp
	public float shotSpeed = 7f;
	public GameObject impactEffect;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position += new Vector3(shotSpeed * Time.deltaTime, 0f, 0f);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Instantiate(impactEffect, transform.position, transform.rotation);

		if (other.tag == "Player")
		{
			HealthManager.instance.HurtPlayer();
		}

		Destroy(this.gameObject);
	}

	private void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
```
- Em seguida adicione esse script ao objeto inimigo (**EnemyShoot**) e arraste a animação **impact effect**
para dentro do atributo público do script chamado **Impact Effect**.

- E para finalizar crie um diretório chamado **Enemies** dentro de __Prefab__ e arraster os dois objetos inimigos
lá pra dentro (o sprite do tiro (**EnemyShot**) e o sprite da nave inimiga (**EnemyGree**) e exclusa o objeto __EnemyShot__.

### Making Enemies Fire

Para fazer com que os inimigos também possam atirar sigamos as orientações abaixo.

- Abra o script **EnemyController** e faça as seguintes alterações:

```csharp
	public float moveSpeed;

	public Vector2 startDirection;

	public bool shouldChangeDirection;
	public float changeDirectionXPoint;
	public Vector2 changedDirection;

	public GameObject shotToFire;
	public Transform firePoint;
	public float timeBetweenShots;
	private float shotCounter;

	// Start is called before the first frame update
	void Start()
	{
		shotCounter = timeBetweenShots;
	}

	// Update is called once per frame
	void Update()
	{
		// transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
		
		if (!shouldChangeDirection)
		{
			transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
		}
		else
		{
			if(transform.position.x > changeDirectionXPoint)
			{
				transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
			}
			else
			{
				transform.position += new Vector3(changedDirection.x * moveSpeed * Time.deltaTime, changedDirection.y * moveSpeed * Time.deltaTime, 0f);
			}
		}

		shotCounter -= Time.deltaTime;
		if(shotCounter <= 0)
		{
			shotCounter = timeBetweenShots;
			Instantiate(shotToFire, firePoint.position, firePoint.rotation);
		}
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
```

- Dentro do objeto **Enemy Green** no atributo público __Shot__ __To__ __Fire__ do componente que comporta o script **EnemyController**
arraste o __Prefab__ **EnemyShoot** para dentro dele e em __Time__ __Between__ __Shots__ deixe marcado com _0.5_;
- Clique com o botão direito em cima do objeto **Enemy Green** e no menu que se abrirá escolha criar um objeto vazio com o nome 
de **Fire Point** e arraste-o para o atributo público __Fire__ __Point__ contido no mesmo componente que comporta script acima.
Por fim dê um _Override_ no objeto **Enemy Green** para suas alterações sejam inclusas no seu __Prefab__.
- Em seguida arraste o __Prefab__ **Enemy Shoot** para dentro da aba __Hierarchy__, adicione um áudio ao mesmo ( _Enemy_ _Laser_ ), 
realize um Override no objeto da aba __Hierarchy__ e exclua-o.

- Em seguida modificaremos mais uma vez o script **EnemyController** como abaixo acrescentando novas variáveis e novas condicionantes.
```csharp
	public float moveSpeed;

	public Vector2 startDirection;

	public bool shouldChangeDirection;
	public float changeDirectionXPoint;
	public Vector2 changedDirection;

	public GameObject shotToFire;
	public Transform firePoint;
	public float timeBetweenShots;
	private float shotCounter;

	public bool canShoot;
	private bool allowShooting;

	// Start is called before the first frame update
	void Start()
	{
		shotCounter = timeBetweenShots;
	}

	// Update is called once per frame
	void Update()
	{
		// transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
		
		if (!shouldChangeDirection)
		{
			transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
		}
		else
		{
			if(transform.position.x > changeDirectionXPoint)
			{
				transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
			}
			else
			{
				transform.position += new Vector3(changedDirection.x * moveSpeed * Time.deltaTime, changedDirection.y * moveSpeed * Time.deltaTime, 0f);
			}
		}

		if (allowShooting)
		{
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0)
			{
				shotCounter = timeBetweenShots;
				Instantiate(shotToFire, firePoint.position, firePoint.rotation);
			}
		}
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	private void OnBecameVisible()
	{
		if (canShoot)
		{
			allowShooting = true;
		}
	}
```
- Agora, no componente script dentro de **Enemy Controller** do objeto **Enemy Green** marcaremos a variável que agora está pública, _Can_ _Shoot_;

- Prosseguimos no __Prefab__ **EnemyShot**, criamos um layer chamado __EnemyShot__, o ordenamos logo abaixo do layer _Enemy_;

  ![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/10_space_shooting_making_enemies.png?raw=true "Enemy Shot")

- Adiante entraremos novamente em __Project__ __Settings__ e retirar os atributos que envolvem tanto o objeto __Enemy__ quanto __Enemy__ __Shot__
da secção __Physics__ __2D__ como no quadro abaixo porque estes _layers_ não devem interagir com os outros nessa secção. Isso faz com que 
o tiro da nave do player não interaja com o tiro da da nave inimiga, assim como em algumas games de Beat'up que não é possível atacar seu parceiro;

  ![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_UDEMY/__MEDIA/12_space_shooting_phisics_2d.png?raw=true "Physics 2D") 

*** Giving Enemies Health
