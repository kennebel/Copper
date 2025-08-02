using Godot;
using System;

public partial class WorldController : Node
{
	public double TimeOfDay { get; set; } = 0.0;

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		// Update the time of day based on delta time
		TimeOfDay += delta * 0.1; // Adjust the multiplier for speed of time progression
		if (TimeOfDay >= 24.0)
		{
			TimeOfDay -= 24.0; // Reset to 0 after a full day
		}
	}
}
