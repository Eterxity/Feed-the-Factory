using Godot;
using System;

public partial class basic_dropper : Node3D
{
	[Export]
	private PackedScene _ore;

	[Export]
	private float _oreDropFreq;

	[Export]
	private Timer _timer;

	[Export]
	private MeshInstance3D _spawner;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta){
		_timer.WaitTime = _oreDropFreq;
	}

	public void _on_timer_timeout(){
		Node3D oreInstance = _ore.Instantiate<Node3D>();
		oreInstance.Position = _spawner.Position;
		CallDeferred("add_child", oreInstance);
		GD.Print("ore dropped");
	}
}
