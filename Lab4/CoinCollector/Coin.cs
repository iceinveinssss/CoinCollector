namespace CoinCollector;

public class Coin : IGameObject
{
    public string Name { get; }
    public int Value { get; }

    public Coin(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public void Draw()
    {
        Console.WriteLine($"Монета: {Name}, стоимость: {Value} очк.");
    }
}
