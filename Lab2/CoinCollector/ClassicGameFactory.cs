namespace CoinCollector;

public class ClassicGameFactory : IGameFactory
{
    private readonly Character _characterPrototype =
        new("Классический герой", new Position(0, 0), 3);

    private readonly GameCoin _coinPrototype =
        new("Золотая монета", new Position(0, 0), 1);

    public Character CreateCharacter() => (Character)_characterPrototype.Clone();
    public GameCoin CreateCoin() => (GameCoin)_coinPrototype.Clone();
}
