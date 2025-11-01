extends CharacterBody2D

@export var _velocidade_de_movimento: float = 128.0

func _physics_process(_delta: float):
	var direcao = Input.get_vector(
		"mover_esquerda", "mover_direita", "mover_cima", "mover_baixo"
	)
	
	velocity = direcao * _velocidade_de_movimento
	move_and_slide()
