namespace CoinCollector;

public class AnimationDecorator : GameObjectDecorator
{
    public AnimationDecorator(IGameObject wrappedObject)
        : base(wrappedObject)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"  Анимация включена для: {Name}");
        base.Draw();
    }
}
