using CoinCollector;

Console.WriteLine("=== Лабораторная работа 3 ===");
Console.WriteLine("Игра «Собиратель монет»");

var movement = new CharacterMovementAdapter(new LegacyCharacter());
movement.Move(new Position(3, 4));

var objects = new GameObjects(
    "Рыцарь",
    new Position(3, 4),
    new List<(string, Position, int)>
    {
        ("Магический кристалл", new Position(5, 2), 5),
        ("Магический кристалл", new Position(8, 6), 5)
    });

var game = new CoinCollectorGame(new ConsoleRenderer());
game.Render(objects);
