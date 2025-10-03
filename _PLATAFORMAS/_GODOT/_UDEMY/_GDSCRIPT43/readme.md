
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

Execução da função print dentro do método ready(), que por sinal atua como um tipo de construtor.

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
