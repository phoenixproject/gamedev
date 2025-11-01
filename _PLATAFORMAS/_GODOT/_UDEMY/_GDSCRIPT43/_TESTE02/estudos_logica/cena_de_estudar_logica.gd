extends Node

@export_category("VAR_STRING")
@export var saudacao : String = "Novo Teste"
# @export var mensagem : String = "Olá novo mundo"
@export var nome_personagem : String

@export_category("VAR_INTEGER")
@export var numero_a : int = 5
@export var numero_b : int = 2

@export_category("VAR_FLOAT")
@export var numero_quebrado_a : float = 0.5
@export var numero_quebrado_b : float = 2.5
@export var vida_do_personagem: int
@export var dano_do_inimigo: int

@export_category("VAR_BOOLEAN")
@export var pode_realizar_divisao : bool = true

@export_category("OBJETOS")
@export var filho_1 : Node
@export var filho_2 : Node

var lista: Array = []
var lista_de_ataque: Array = [3, 7]
var lista_dicionario: Dictionary = {}
var dialogo_npc_1 : Dictionary = {
	"lista_de_frases" : {
		0 : "Ola",
		1 : "Tudo bem com você?",
		2 : "Me chamado Ming"
	},
	
	"expressoes_faciais" : {
		0 : "Amigável",
		1 : "Questionando",
		2 : "Triste"
	},
	
	"nomes_npcs" : {
		0 : "Ming",
		1 : "Gran Diano",
		2 : "Junior San"
	}
}

func _ready() -> void:
	# var mensagem : String = "Olá novo mundo"
	
	# ola_mundo1()
	# ola_mundo2(mensagem)
	# soma()
	# print(saudacao)
	#divisao()
	lista_e_randomizacao()
		
func _process(delta: float) -> void:
	# Input.is_action_just_pressed("im_atacar")
	# print(delta)
	pass

func _physics_process(delta: float) -> void:
	# print(delta)
	if(Input.is_action_just_pressed("im_atacar")):
		vida_do_personagem = vida_do_personagem - dano_do_inimigo
		
		if vida_do_personagem > 0:
			print("O personagem está vivo. Vida do personagem: " + str(vida_do_personagem))
		elif vida_do_personagem == 0:
			print("O personagem acabou de morrer")
		else:
			print("O inimigo está atacando um alvo morto")
		
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
		
func lista_e_randomizacao():
	# Número INTEIRO aleatório
	print(randi_range(lista_de_ataque[0], lista_de_ataque[1]))
	# Número QUEBRADO aleatório
	print(randf_range(lista_de_ataque[0], lista_de_ataque[1]))

	var ataque: int = randi_range(lista_de_ataque[0], lista_de_ataque[1])
	print(ataque)
	
	lista_dicionario[0] = filho_1
	lista_dicionario[10] = filho_2
		
	print(lista_dicionario)
	
	lista_dicionario[0] = {
		"objeto": filho_1,
		"nome": "Ming",
		"idade": 25,
		"profissão": "Desenvolvedor de Jogos"
	}
	
	print(lista_dicionario[0])
	print(lista_dicionario[0]["nome"])
	
	print(dialogo_npc_1["lista_de_frases"][2])
	print(dialogo_npc_1)
