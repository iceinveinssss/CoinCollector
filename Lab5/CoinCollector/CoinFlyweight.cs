namespace CoinCollector;

public class CoinFlyweight
{
    public string Appearance { get; }
    public string Sound { get; }
    public int Value { get; }

    public CoinFlyweight(string appearance, string sound, int value)
    {
        Appearance = appearance;
        Sound = sound;
        Value = value;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Монета [{Appearance}] в ({x}, {y}), звук: {Sound}, стоимость: {Value}.");
    }
}