namespace CoinCollector;

public abstract class GameItem
{
    public string Appearance { get; set; }
    public Position Position { get; set; }

    protected GameItem(string appearance, Position position)
    {
        Appearance = appearance;
        Position = position;
    }

    public abstract GameItem Clone();
}
