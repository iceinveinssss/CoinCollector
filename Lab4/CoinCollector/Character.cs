namespace CoinCollector;

public class Character : IGameObject
{
    public string Name { get; }

    public Character(string name)
    {
        Name = name;
    }

    public void Draw()
    {
        Console.WriteLine($"Персонаж: {Name}");
    }
}
