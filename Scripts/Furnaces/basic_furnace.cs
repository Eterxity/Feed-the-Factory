using Godot;
using System;

public partial class basic_furnace : Node3D
{

	[Export] int _multiplier;

	public void _on_area_3d_body_entered(Node3D body){
		var moneyGained = body.GetParentNode3D().Get("_worth");
		moneyGained = Mathf.RoundToInt(moneyGained.As<float>());
		resources._money += moneyGained.As<int>() * _multiplier;
		GD.Print(resources._money);
		body.QueueFree();
	}
	
}
