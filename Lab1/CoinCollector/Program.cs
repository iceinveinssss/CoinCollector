using CoinCollector;

Game game = new GameBuilder()
    .SetFieldSize(20, 15)
    .SetDifficulty("Средний")
    .SetPlayer("Иван", 3)
    .SetPlayerPosition(2, 2)
    .SetCoinsCount(10)
    .Build();

game.PrintInfo();
