using CoinCollector;

Console.WriteLine("=== Лабораторная работа 5 ===");
Console.WriteLine("Игра «Собиратель монет»");

var facade = new GameFacade(
    new GameInput(),
    new GameRenderer(),
    new ScoreManager(),
    new CollisionSystem());

facade.StartGame();
facade.CollectCoin(1);

var factory = new CoinFactory();
var gold = factory.GetCoin("Золотая", "Звон", 1);

new Coin(gold, 2, 3).Draw();
new Coin(gold, 6, 4).Draw();
new Coin(gold, 10, 8).Draw();

Console.WriteLine($"Количество уникальных объектов-приспособленцев: {factory.CachedCount}");
