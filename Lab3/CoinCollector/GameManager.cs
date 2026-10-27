
namespace CoinCollector;

public sealed class GameManager
{
    private static readonly Lazy<GameManager> _instance =
        new(() => new GameManager());

    public static GameManager Instance => _instance.Value;

    public Game? CurrentGame { get; private set; }

    public int CollectedCoins { get; private set; }

    public bool IsGameRunning { get; private set; }

    private GameManager()
    {
    }

    public void StartGame(Game game)
    {
        CurrentGame = game;
        CollectedCoins = 0;
        IsGameRunning = true;
    }

    public void CollectCoin()
    {
        if (!IsGameRunning)
            return;

        CollectedCoins++;
    }

    public void EndGame()
    {
        IsGameRunning = false;
    }

    public void PrintStatus()
    {
        Console.WriteLine("\n=== Состояние игры ===");
        Console.WriteLine($"Собрано монет: {CollectedCoins}");
        Console.WriteLine(
            $"Статус: {(IsGameRunning ? "Игра идёт" : "Игра завершена")}");
    }
}
