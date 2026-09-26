namespace CoinCollector;

public class GameCoin : GameItem
{
    public int Value { get; set; }

    public GameCoin(string appearance, Position position, int value)
        : base(appearance, position)
    {
        Value = value;
    }

    public override GameItem Clone()
        => new GameCoin(Appearance, new Position(Position.X, Position.Y), Value);
}
