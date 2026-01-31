extends Node3D

class_name Activator

@export var HelloComponent: Greeter

func _ready() -> void:
	if HelloComponent == null:
		push_warning("No Greeter assigned to UsesGreeter.gd")
		return
		
	print(HelloComponent.SayHello())
	pass

#func _ungandled_input(event: InputEvent) -> void:
	#if event is InputEventKey and event.pressed and not event.echo:
		#if event.keycode == KEY_6:
			#print(HelloComponent.say_hellow_world())
	#pass
