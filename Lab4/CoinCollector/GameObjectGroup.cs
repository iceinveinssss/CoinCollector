namespace CoinCollector;

public class GameObjectGroup : IGameObject
{
    private readonly List<IGameObject> _objects = new();

    public string Name { get; }

    public GameObjectGroup(string name)
    {
        Name = name;
    }

    public void Add(IGameObject gameObject) => _objects.Add(gameObject);
    public void Remove(IGameObject gameObject) => _objects.Remove(gameObject);

    public void Draw()
    {
        Console.WriteLine($"Группа: {Name}");
        foreach (var gameObject in _objects)
            gameObject.Draw();
    }
}
