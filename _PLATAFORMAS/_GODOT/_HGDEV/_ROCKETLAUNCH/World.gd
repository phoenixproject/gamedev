 extends Node

onready var animationPlayer = get_node("AnimationPlayer")
#onready var animationPlayer = $animationPlayer

#func _ready():
#	animationPlayer.play("Launch")

func _on_LaunchButton_pressed():
	#pass # Replace with function body.
	animationPlayer.play("Launch")
