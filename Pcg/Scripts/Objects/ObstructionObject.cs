using Godot;
using System;

public partial class ObstructionObject : StaticBody2D
{
    #region Required Components
    [Export] public Texture2D DmgSprite { get; private set; }
    [Export] public Texture2D UnDmgdSprite { get; private set; }
    [Export] private Sprite2D _sprite;
    #endregion
    
    #region Object Stats
    [Export] public int MaxHP { get; set; } = 20;
    [Export] private int _currentHp;
    #endregion

    public override void _Ready()
    {
        _sprite.Texture = UnDmgdSprite;
        _currentHp = MaxHP;
        
        EnableNode();
    }

    public void DamageObject(int amount)
    {
        _currentHp -= amount;

        if (_currentHp <= Mathf.Round(MaxHP * 0.75f))
        {
            _sprite.Texture = DmgSprite;
        }

        _currentHp = Mathf.Clamp(_currentHp, 0, MaxHP);

        if (_currentHp == 0)
        {
            DisableNode();
        }
    }

    void DisableNode()
    {
        SetProcess(false);
        SetPhysicsProcess(false);
        Visible = false;
    }

    void EnableNode()
    {
        SetProcess(true);
        SetPhysicsProcess(true);
        Visible = true;
    }
}
