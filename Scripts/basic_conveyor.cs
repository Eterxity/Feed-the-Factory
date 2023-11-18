using Godot;
using System;

public partial class basic_conveyor : StaticBody3D
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		if (Mathf.Round(RotationDegrees.Y) == 0){
			ConstantLinearVelocity = new Vector3(2, 0, 0);
		}
		if (Mathf.Round(RotationDegrees.Y) == 90){
			ConstantLinearVelocity = new Vector3(0, 0, -2);
		}		
		if (Mathf.Round(RotationDegrees.Y) == -180){
			ConstantLinearVelocity = new Vector3(-2, 0, 0);
		}
		if (Mathf.Round(RotationDegrees.Y) == -90){
			ConstantLinearVelocity = new Vector3(0, 0, 2);
		}

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
