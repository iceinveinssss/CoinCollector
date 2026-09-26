namespace CoinCollector;

public class ScoreDecorator : GameObjectDecorator
{
    private readonly int _bonusScore;

    public ScoreDecorator(IGameObject wrappedObject, int bonusScore)
        : base(wrappedObject)
    {
        _bonusScore = bonusScore;
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine($"  Бонус за объект: +{_bonusScore} очк.");
    }
}
