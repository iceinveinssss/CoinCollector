namespace CoinCollector;

public class Character : GameItem
{
    public int Health { get; set; }

    public Character(string appearance, Position position, int health)
        : base(appearance, position)
    {
        Health = health;
    }

    public override GameItem Clone()
        => new Character(Appearance, new Position(Position.X, Position.Y), Health);
}
