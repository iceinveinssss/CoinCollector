# Лабораторная работа 3

## Структурные паттерны: Адаптер и Мост

Предметная область: игра «Собиратель монет».

### Использованные паттерны

1. **Адаптер (Adapter)** — обеспечивает совместимость нового интерфейса управления персонажем с существующим классом LegacyCharacter. Игровой код работает с ICharacterMovement, а адаптер преобразует вызов Move в старый метод MoveCharacter.
2. **Мост (Bridge)** — отделяет игровую логику от способа отображения. Абстракция Game использует интерфейс IGameRenderer, поэтому игровая часть может работать с разными реализациями отображения без изменения самой игры.

### Структура

    Lab3/
    ├── README.md
    └── CoinCollector/
        ├── CoinCollector.csproj
        ├── Program.cs
        ├── Position.cs
        ├── LegacyCharacter.cs
        ├── ICharacterMovement.cs
        ├── CharacterMovementAdapter.cs
        ├── IGameRenderer.cs
        ├── ConsoleRenderer.cs
        ├── GameObjects.cs
        └── Game.cs

### Результат

Демонстрируется совместная работа двух структурных паттернов: адаптер подключает существующий модуль перемещения персонажа, а мост позволяет отделить игровую логику от механизма отображения.

### Запуск

Требуется .NET 8 SDK.

Из каталога Lab3/CoinCollector выполните:

    dotnet run

### Репозиторий

https://github.com/iceinveinssss/CoinCollector
