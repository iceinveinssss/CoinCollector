namespace CoinCollector;

public class CoinFactory
{
    private readonly Dictionary<string, CoinFlyweight> _flyweights = new();

    public CoinFlyweight GetCoin(string appearance, string sound, int value)
    {
        string key = $"{appearance}|{sound}|{value}";
        if (!_flyweights.TryGetValue(key, out var flyweight))
        {
            flyweight = new CoinFlyweight(appearance, sound, value);
            _flyweights[key] = flyweight;
        }
        return flyweight;
    }

    public int CachedCount => _flyweights.Count;
}