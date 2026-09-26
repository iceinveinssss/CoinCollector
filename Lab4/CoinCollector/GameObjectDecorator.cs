namespace CoinCollector;

public abstract class GameObjectDecorator : IGameObject
{
    protected readonly IGameObject WrappedObject;

    protected GameObjectDecorator(IGameObject wrappedObject)
    {
        WrappedObject = wrappedObject;
    }

    public virtual string Name => WrappedObject.Name;

    public virtual void Draw() => WrappedObject.Draw();
}
