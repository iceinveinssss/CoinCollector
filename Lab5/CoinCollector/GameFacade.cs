namespace CoinCollector;

public class GameFacade
{
    private readonly GameInput _input;
    private readonly GameRenderer _renderer;
    private readonly ScoreManager _score;
    private readonly CollisionSystem _collision;

    public GameFacade(GameInput input, GameRenderer renderer, ScoreManager score, CollisionSystem collision)
    {
        _input = input;
        _renderer = renderer;
        _score = score;
        _collision = collision;
    }

    public void StartGame()
    {
        Console.WriteLine("Запуск игры...");
        _input.Configure();
        _renderer.Initialize();
        _collision.Initialize();
        _score.Reset();
        _renderer.DrawScene();
        Console.WriteLine("Игра готова к началу.");
    }

    public void CollectCoin(int value) => _score.AddPoints(value);
}