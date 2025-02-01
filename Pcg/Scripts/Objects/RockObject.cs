using Godot;
using System;

public partial class RockObject : StaticBody2D
{
    [Export] public TileMapLayer dmgSprite { get; set; }
    [Export] public int hp { get; set; }
}
