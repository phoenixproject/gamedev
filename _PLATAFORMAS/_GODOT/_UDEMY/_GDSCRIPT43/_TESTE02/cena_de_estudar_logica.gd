extends Node

var mensagem

func _ready():
	mensagem = "Olá novo mundo"
	
	ola_mundo1()
	ola_mundo2(mensagem)
	
func ola_mundo1():
	print("Olá mundo")
	
func ola_mundo2(mensagem):
	print(mensagem)
