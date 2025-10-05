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
