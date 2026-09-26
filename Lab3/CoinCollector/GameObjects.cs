namespace CoinCollector;

public class GameObjects
{
    public string CharacterAppearance { get; }
    public Position CharacterPosition { get; }
    public List<(string Appearance, Position Position, int Value)> Coins { get; }

    public GameObjects(
        string characterAppearance,
        Position characterPosition,
        List<(string Appearance, Position Position, int Value)> coins)
    {
        CharacterAppearance = characterAppearance;
        CharacterPosition = characterPosition;
        Coins = coins;
    }
}
