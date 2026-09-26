namespace CoinCollector;

public class FantasyGameFactory : IGameFactory
{
    private readonly Character _characterPrototype =
        new("Рыцарь", new Position(0, 0), 5);

    private readonly GameCoin _coinPrototype =
        new("Магический кристалл", new Position(0, 0), 5);

    public Character CreateCharacter() => (Character)_characterPrototype.Clone();
    public GameCoin CreateCoin() => (GameCoin)_coinPrototype.Clone();
}
