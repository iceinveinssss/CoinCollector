namespace CoinCollector;

public abstract class Game
{
    protected readonly IGameRenderer Renderer;

    protected Game(IGameRenderer renderer)
    {
        Renderer = renderer;
    }

    public abstract void Render(GameObjects objects);
}

public class CoinCollectorGame : Game
{
    public CoinCollectorGame(IGameRenderer renderer)
        : base(renderer)
    {
    }

    public override void Render(GameObjects objects)
    {
        Renderer.DrawCharacter(objects.CharacterAppearance, objects.CharacterPosition);

        foreach (var coin in objects.Coins)
            Renderer.DrawCoin(coin.Appearance, coin.Position, coin.Value);
    }
}
