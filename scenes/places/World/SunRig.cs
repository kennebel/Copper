using Godot;
using System;

public partial class SunRig : Node3D
{
	[Export]
	public WorldController TheWorld { get; set; }

	public override void _Process(double delta)
	{
		this.Rotation = new Vector3(0, 0, Utilities.TwoPi * ((float)TheWorld.TimeOfDay / 24f));
		if (TheWorld.TimeOfDay < 12.0) { this.Visible = true; } else { this.Visible = false; }
	}
}
