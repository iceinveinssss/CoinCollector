namespace CoinCollector;

public class Game
{
    public int Width { get; }
    public int Height { get; }
    public string Difficulty { get; }
    public Player Player { get; }
    public List<Coin> Coins { get; }

    public Game(int width, int height, string difficulty, Player player, List<Coin> coins)
    {
        Width = width;
        Height = height;
        Difficulty = difficulty;
        Player = player;
        Coins = coins;
    }

    public void PrintInfo()
    {
        Console.WriteLine("=== Игра «Собиратель монет» ===");
        Console.WriteLine($"Поле: {Width} x {Height}");
        Console.WriteLine($"Сложность: {Difficulty}");
        Console.WriteLine($"Игрок: {Player.Name}");
        Console.WriteLine($"Здоровье: {Player.Health}");
        Console.WriteLine($"Позиция игрока: {Player.Position}");
        Console.WriteLine($"Количество монет: {Coins.Count}");

        foreach (var coin in Coins)
            Console.WriteLine($"Монета: {coin.Value} очк. на позиции {coin.Position}");
    }
}
