extends Node2D


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
	
func _init():
	print("1º - Hello, world!")	
	
	var carro1 = Carro.new("Uno")
	carro1.add_velocity(40)
	print(carro1.fuel)
	print(carro1.getTipoCarro())
	
	print(" -- ")
	
	var carro2 = Carro.new("Passat")
	carro2.add_velocity(80)
	print(carro2.fuel)
	print(carro2.getTipoCarro())
