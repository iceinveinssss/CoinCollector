namespace CoinCollector;

public class Coin
{
    public int Value { get; set; }
    public Position Position { get; set; }

    public Coin(int value, Position position)
    {
        Value = value;
        Position = position;
    }
}
