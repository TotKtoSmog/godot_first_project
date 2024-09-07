using Godot;
using System;

public partial class GoDotSc : Sprite2D
{
	private int _speed = 400;
	private float _angularSpeed = Mathf.Pi;
	public override void _Ready()
	{
	}
	public override void _Process(double delta)
	{
		Rotation += _angularSpeed * (float)delta;
		GD.Print($"Rotation: {Rotation}");
	}
	public GoDotSc() => GD.Print("Hello, world!");
}
