namespace CoinCollector;

public interface IGameRenderer
{
    void DrawCharacter(string appearance, Position position);
    void DrawCoin(string appearance, Position position, int value);
}
