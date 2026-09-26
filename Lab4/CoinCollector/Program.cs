using CoinCollector;

Console.WriteLine("=== Лабораторная работа 4 ===");
Console.WriteLine("Игра «Собиратель монет»");

IGameObject character = new Character("Рыцарь");
IGameObject coin1 = new Coin("Золотая монета", 1);
IGameObject coin2 = new Coin("Магический кристалл", 5);

IGameObject decoratedCharacter =
    new AnimationDecorator(new ScoreDecorator(character, 10));

IGameObject decoratedCoin =
    new AnimationDecorator(new ScoreDecorator(coin2, 5));

var gameObjects = new GameObjectGroup("Игровое поле");
gameObjects.Add(decoratedCharacter);
gameObjects.Add(coin1);
gameObjects.Add(decoratedCoin);

gameObjects.Draw();
