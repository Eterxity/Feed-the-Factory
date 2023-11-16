using Godot;
using System;

public partial class basic_furnace : Node3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_area_3d_body_entered(Node3D body){
		var moneyGained = body.Get("worth");
		resources._money += moneyGained.As<float>();
		body.QueueFree();
	}
}
