using CoinCollector;

IGameFactory factory = new FantasyGameFactory();

Character character = factory.CreateCharacter();
character.Position = new Position(2, 2);

var coins = new List<GameCoin>();

for (int i = 0; i < 5; i++)
{
    GameCoin coin = factory.CreateCoin();
    coin.Position = new Position(i + 1, i + 2);
    coins.Add(coin);
}

Game game = new Game(character, coins);
game.PrintInfo();
