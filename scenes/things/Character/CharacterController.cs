using Godot;
using System;

public partial class CharacterController : Node
{
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
}
