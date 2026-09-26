namespace CoinCollector;

public class Game
{
    public Character Character { get; }
    public List<GameCoin> Coins { get; }

    public Game(Character character, List<GameCoin> coins)
    {
        Character = character;
        Coins = coins;
    }

    public void PrintInfo()
    {
        Console.WriteLine("=== Лабораторная работа 2 ===");
        Console.WriteLine("Игра «Собиратель монет»");
        Console.WriteLine($"Персонаж: {Character.Appearance}");
        Console.WriteLine($"Здоровье: {Character.Health}");
        Console.WriteLine($"Позиция: {Character.Position}");
        Console.WriteLine($"Монет создано: {Coins.Count}");

        foreach (var coin in Coins)
            Console.WriteLine($"Монета: {coin.Appearance}, {coin.Value} очк., позиция {coin.Position}");
    }
}
