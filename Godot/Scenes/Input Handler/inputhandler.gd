extends Node

var attack_held := false

func _process(delta: float) -> void:
	if Input.is_action_just_pressed("attack"):
		attack_held = true
		print("ATTACK PRESSED")
