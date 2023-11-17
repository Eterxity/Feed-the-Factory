using Godot;
using System;

public partial class basic_conveyor : StaticBody3D
{

	[Export] StaticBody3D _self;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if (_self.RotationDegrees.Y == 0){
			_self.ConstantLinearVelocity = Vector3.Right * 2;
		}
		if (_self.RotationDegrees.Y == 90){
			_self.ConstantLinearVelocity = Vector3.Forward * 2;
		}
		if (_self.RotationDegrees.Y == -180){
			_self.ConstantLinearVelocity = Vector3.Left * 2;
		}
		if (_self.RotationDegrees.Y == -90){
			_self.ConstantLinearVelocity = Vector3.Back * 2;
		}
	}
}
