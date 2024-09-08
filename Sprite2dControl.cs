using Godot;
using System;

public partial class Sprite2dControl : Sprite2D
{
	private int _speed = 400;
	private float _angularSpeed = Mathf.Pi;
	public override void _Ready()
	{
	}
	public override void _Process(double delta)
	{

		Rotation += Rotait(_angularSpeed, (float)delta);
		
		Position += MoveDirection((float)delta);

		GD.Print($"Position: {Position}");
		GD.Print($"Rotation: {Rotation}");

	}
	public Sprite2dControl() => GD.Print("Hello, world!");

	public float Rotait(float angularSpeed, float delta)
	{
		var direction = 0;
		if (Input.IsActionPressed("ui_left"))
			direction = -1;
		if (Input.IsActionPressed("ui_right"))
			direction = 1;
		return _angularSpeed * direction * delta;
	}
	public Vector2 MoveDirection(float delta)
	{
		var velocity = Vector2.Zero;
		if (Input.IsActionPressed("ui_up"))
			velocity = Vector2.Up.Rotated(Rotation) * _speed;
		if (Input.IsActionPressed("ui_down"))
			velocity = Vector2.Down.Rotated(Rotation) * _speed;
		return velocity * delta;
	}
}
