using Godot;
using System;

public partial class CharacterController : CharacterBody3D
{
	[ExportGroup("Movement")]
	[Export]
	public float Speed { get; set; } = 10f;

	[ExportGroup("Shapes")]
	[Export]
	public MeshInstance3D MainBody { get; set; }
	[Export]
	public MeshInstance3D Nose { get; set; }
	[Export]
	public MeshInstance3D EyeLeft { get; set; }
	[Export]
	public MeshInstance3D EyeRight { get; set; }
	[Export]
	public MeshInstance3D ArmLeft { get; set; }
	[Export]
	public MeshInstance3D ArmRight { get; set; }
	[Export]
	public MeshInstance3D RearLeft { get; set; }
	[Export]
	public MeshInstance3D RearRight { get; set; }

	[ExportGroup("Rigs")]
	[Export]
	public Node3D FaceRig { get; set; }
	[Export]
	public Node3D ArmLeftRig { get; set; }
	[Export]
	public Node3D ArmRightRig { get; set; }
	[Export]
	public Node3D CrownRig { get; set; }
	[Export]
	public Node3D RearRig { get; set; }

	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyEvent && keyEvent.IsActionPressed("move_forward"))
		{
			this.Velocity += Vector3.Forward * Speed;
		}
		if (@event is InputEventKey keyEvent2 && keyEvent2.IsActionPressed("move_backward"))
		{
			this.Velocity += Vector3.Back * Speed;
		}
		if (@event is InputEventKey keyEvent3 && keyEvent3.IsActionPressed("move_left"))
		{
			this.Velocity += Vector3.Left * Speed;
		}
		if (@event is InputEventKey keyEvent4 && keyEvent4.IsActionPressed("move_right"))
		{
			this.Velocity += Vector3.Right * Speed;
		}

		if (@event is InputEventKey keyEvent5 && keyEvent5.IsActionReleased("move_forward"))
		{
			this.Velocity -= Vector3.Forward * Speed;
		}
		if (@event is InputEventKey keyEvent6 && keyEvent6.IsActionReleased("move_backward"))
		{
			this.Velocity -= Vector3.Back * Speed;
		}
		if (@event is InputEventKey keyEvent7 && keyEvent7.IsActionPressed("move_left"))
		{
			this.Velocity -= Vector3.Left * Speed;
		}
		if (@event is InputEventKey keyEvent8 && keyEvent8.IsActionPressed("move_right"))
		{
			this.Velocity -= Vector3.Right * Speed;
		}

		if (!Input.IsAnythingPressed())
		{
			this.Velocity = Vector3.Zero;
		}
	}

	public override void _PhysicsProcess(double delta)
	{
		if (this.Velocity != Vector3.Zero)
		{
			this.MoveAndCollide(this.Velocity * (float)delta);
			//this.Velocity = Vector3.Zero;
		}
	}
}
