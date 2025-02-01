using Godot;
using System;
using Godot.Collections;

public partial class GameBoardSpawner : Node
{
    #region PCG Spawning Rules
    [Export] public int Columns { get; private set; } = 5;
    [Export] public int Rows { get; private set; } = 5;
    #endregion
    
    #region Spawned Objects
    [Export] private PackedScene[] _floorTiles;
    private Transform2D _boardHolder;
    private Dictionary<Vector2, Vector2> _gridPositions = new Dictionary<Vector2, Vector2>();
    #endregion
}

[Serializable]
public class Count
{
    public int Minimum;
    public int Maximum;
        
    public Count(int min, int max)
    {
        Minimum = min;
        Maximum = max;
    }
}
