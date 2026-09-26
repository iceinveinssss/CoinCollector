namespace CoinCollector;

public class GameBuilder
{
    private int _width = 20;
    private int _height = 15;
    private string _difficulty = "Средний";
    private string _playerName = "Игрок";
    private int _health = 3;
    private Position _playerPosition = new(0, 0);
    private int _coinsCount = 10;

    public GameBuilder SetFieldSize(int width, int height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Размеры поля должны быть положительными.");

        _width = width;
        _height = height;
        return this;
    }

    public GameBuilder SetDifficulty(string difficulty)
    {
        _difficulty = difficulty;
        return this;
    }

    public GameBuilder SetPlayer(string name, int health)
    {
        _playerName = name;
        _health = health;
        return this;
    }

    public GameBuilder SetPlayerPosition(int x, int y)
    {
        _playerPosition = new Position(x, y);
        return this;
    }

    public GameBuilder SetCoinsCount(int count)
    {
        if (count < 0)
            throw new ArgumentException("Количество монет не может быть отрицательным.");

        _coinsCount = count;
        return this;
    }

    public Game Build()
    {
        var player = new Player(_playerName, _health, _playerPosition);
        var coins = new List<Coin>();
        var random = new Random();

        for (int i = 0; i < _coinsCount; i++)
        {
            var position = new Position(
                random.Next(0, _width),
                random.Next(0, _height));

            coins.Add(new Coin(1, position));
        }

        return new Game(_width, _height, _difficulty, player, coins);
    }
}
