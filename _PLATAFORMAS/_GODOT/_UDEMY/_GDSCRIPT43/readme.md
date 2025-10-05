
Última aula: https://www.udemy.com/course/aprenda-godot-e-gdscript-em-7-dias/learn/lecture/46001893#overview

- Cena: uma cena pode ter diversos objetos e esses objetos podem ser salvos como outras cenas.

- Atalhos:
	- F6: executa a cena em questão (desde que tenha sido salva);
	

##### Para salvar um objeto como uma cena	
	
![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_01.png?raw=true "Objeto como cena")	

##### Para alterar a Cena Principal

Vale lembrar que em dados momentos vocês pode e deve salvar alguma cena como principal, porém quando precisar alterar quem é a principal basta seguir em Project > General > Run

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_02.png?raw=true "Inserção de Script")	

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_03.png?raw=true "Inserção de Script")	

##### Para inciar um script na Godot

É necessário, ao atachar um script num objeto, logo no início do script herdar o tipo do objeto atachado ao script. Também é possível ver a documentação da classe do objeto ao clicar com o botão direito em cima dele.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_04.png?raw=true "Iniciando um script")	

Execução da função print dentro do método _ready(), que por sinal atua como um tipo de construtor, ela executa a partir do momento em que o objeto é renderizado na cena do jogo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_05.png?raw=true "Iniciando um script")	

Passando parâmetro para uma função de uma variável global.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_06.png?raw=true "Passando parâmetro")	

Exemplo de funções básicas na Godot:

```python
extends Node

var mensagem : String = "Olá novo mundo"

var numero_a : int = 5
var numero_b : int = 2

var numero_quebrado_a : float = 0.5
var numero_quebrado_b : float = 2.5

var pode_realizar_divisao : bool = true

func _ready() -> void:
	# var mensagem : String = "Olá novo mundo"
	
	# ola_mundo1()
	# ola_mundo2(mensagem)
	# soma()
	divisao()
	
func ola_mundo1():
	print("Olá mundo")
	
func ola_mundo2(mensagem):
	print(mensagem)

func soma():
	
	print("O número A era " + str(numero_a))
	print("O número B era " + str(numero_b))
	
	var auxiliar : int
	auxiliar = numero_a
	numero_a = numero_b
	numero_b = auxiliar
	
	print("O número A é " + str(numero_a))
	print("O número B é " + str(numero_b))
	
	print("A soma do número a e do número b é " + str(numero_a + numero_b))

func divisao():
	var resultado_da_divisao1: int = int(numero_a / numero_quebrado_a)
	var resultado_da_divisao2: int = (numero_a / numero_quebrado_a)
	var resultado_da_divisao3: float = (numero_a / numero_quebrado_a)

	if pode_realizar_divisao:		
		print(resultado_da_divisao1)
		print(resultado_da_divisao2)
		print(resultado_da_divisao3)
	else:
		print("Não pode realizar a divisão")
```

Variáveis do tipo @export podem receber valores estáticos, contudo ao declaramos uma variável do tipo @export o inspetor da Godot entende que há um novo atributo parametrizável e quando seu valor é alterado ele sobrepõe o já declarado no código

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_07.png?raw=true "Variável Export")	

##### Para obter valores de inputs a partir de Input Map

Variáveis do tipo @export_category servem para agrupar, para que se agrupe é preciso declará-la antes das variáveis que se quer agrupar e o inspetor da Godot entende que há novas grupos parametrizáveis.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_08.png?raw=true "Variável Export Category")	

Entre as funções _process e _physics_process, para movimentações de personagens o aconselhável é utilizar a _physics_process porque ela trabalha com valores constantes, ou seja, em todos os frames o personagem terá a mesma velocidade de movimento, quando na _process essa velocidade pode variar. São quadros imperceptíveis a olho nú mas tudo o que engloba vetores, físicas de personagens 2d, por questões de boa prática, devemos utilizar na _physics_process, agora todo o resto que é preciso ficar atento a movimentação de frames é interessante que fique na _process.
Entre outras coisas, _physics_process e _process são utilizados para monitoramos as ações, sejam do teclado ou do mouse.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_09.png?raw=true "Variável Export Category")	

O mapeamento de Input Map deve ocorrer quando o mapeamento padrão da Godot está desativado (como na opção Mostrar Ações Integradas).

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/_GDSCRIPT43/teste01_10.png?raw=true "Variável Export Category")	

Para capturar determinado input mapeado basta executar a chamada Input.is_action_just_pressed("im_atacar") (no caso acima o input map foi mapeado com o prefixo im_).

```
extends Node

@export_category("VAR_STRING")
@export var saudacao : String = "Novo Teste"
@export var mensagem : String = "Olá novo mundo"

@export_category("VAR_INTEGER")
@export var numero_a : int = 5
@export var numero_b : int = 2

@export_category("VAR_FLOAT")
@export var numero_quebrado_a : float = 0.5
@export var numero_quebrado_b : float = 2.5

@export_category("VAR_BOOLEAN")
@export var pode_realizar_divisao : bool = true

func _ready() -> void:
	# var mensagem : String = "Olá novo mundo"
	
	# ola_mundo1()
	# ola_mundo2(mensagem)
	# soma()
	print(saudacao)
	divisao()
	
func _process(delta: float) -> void:
	Input.is_action_just_pressed("im_atacar")
	print(delta)
	pass

func _physics_process(delta: float) -> void:
	print(delta)
	pass	
	
func ola_mundo1():	
	print("Olá mundo")
	
func ola_mundo2(mensagem):
	print(mensagem)

func soma():
	
	print("O número A era " + str(numero_a))
	print("O número B era " + str(numero_b))
	
	var auxiliar : int
	auxiliar = numero_a
	numero_a = numero_b
	numero_b = auxiliar
	
	print("O número A é " + str(numero_a))
	print("O número B é " + str(numero_b))
	
	print("A soma do número a e do número b é " + str(numero_a + numero_b))

func divisao():
	var resultado_da_divisao1: int = int(numero_a / numero_quebrado_a)
	var resultado_da_divisao2: int = (numero_a / numero_quebrado_a)
	var resultado_da_divisao3: float = (numero_a / numero_quebrado_a)

	if pode_realizar_divisao:		
		print(resultado_da_divisao1)
		print(resultado_da_divisao2)
		print(resultado_da_divisao3)
	else:
		print("Não pode realizar a divisão")

```