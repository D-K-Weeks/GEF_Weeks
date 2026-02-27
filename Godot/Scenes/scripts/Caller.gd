extends Node3D

class_name Caller

@export var receiver: Receiver

func _ready() -> void:
	if receiver == null:
		push_warning("No Receiver assigned")
		return
		
	print(receiver.OnCalled())
	pass

#func _ungandled_input(event: InputEvent) -> void:
	#if event is InputEventKey and event.pressed and not event.echo:
		#if event.keycode == KEY_6:
			#print(HelloComponent.say_hellow_world())
	#pass
