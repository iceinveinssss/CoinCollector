namespace CoinCollector;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Position Position { get; set; }

    public Player(string name, int health, Position position)
    {
        Name = name;
        Health = health;
        Position = position;
    }
}
