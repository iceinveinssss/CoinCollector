namespace CoinCollector;

public class ConsoleRenderer : IGameRenderer
{
    public void DrawCharacter(string appearance, Position position)
    {
        Console.WriteLine($"Персонаж [{appearance}] отображён в позиции {position}.");
    }

    public void DrawCoin(string appearance, Position position, int value)
    {
        Console.WriteLine($"Монета [{appearance}], {value} очк. отображена в позиции {position}.");
    }
}
