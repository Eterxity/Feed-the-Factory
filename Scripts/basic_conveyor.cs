using Godot;
using System;

public partial class basic_conveyor : StaticBody3D
{

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

}
