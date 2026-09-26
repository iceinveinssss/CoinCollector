namespace CoinCollector;

public class Coin
{
    private readonly CoinFlyweight _flyweight;
    private readonly int _x;
    private readonly int _y;

    public Coin(CoinFlyweight flyweight, int x, int y)
    {
        _flyweight = flyweight;
        _x = x;
        _y = y;
    }

    public void Draw() => _flyweight.Draw(_x, _y);
}