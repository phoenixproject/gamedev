 extends Node

onready var animationPlayer = get_node("AnimationPlayer")
#onready var animationPlayer = $animationPlayer

func _ready():
	animationPlayer.play("Launch")
