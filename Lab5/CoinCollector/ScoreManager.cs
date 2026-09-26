namespace CoinCollector;

public class ScoreManager
{
    public int Score { get; private set; }
    public void Reset() { Score = 0; Console.WriteLine("Счёт сброшен."); }
    public void AddPoints(int points) { Score += points; Console.WriteLine($"Получено очков: {points}. Текущий счёт: {Score}."); }
}