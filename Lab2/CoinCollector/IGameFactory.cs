namespace CoinCollector;

public interface IGameFactory
{
    Character CreateCharacter();
    GameCoin CreateCoin();
}
