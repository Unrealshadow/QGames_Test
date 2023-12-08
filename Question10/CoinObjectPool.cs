class CoinObjectPool
{
    private readonly Queue<Coin> _coinPool = new Queue<Coin>();
    private readonly List<Coin> _activeCoins = new List<Coin>();
    private const int MaxCoins = 10000;

    public CoinObjectPool()
    {
        for (int i = 0; i < MaxCoins; i++)
        {
            _coinPool.Enqueue(new Coin());
        }
    }

    public Coin GetCoin()
    {
        if (_coinPool.Count > 0)
        {
            var coin = _coinPool.Dequeue();
            coin.Reset();
            _activeCoins.Add(coin);
            return coin;
        }

        return null; // or throw an exception if this scenario is unexpected
    }

    public void ReleaseCoin(Coin coin)
    {
        if (coin != null)
        {
            _activeCoins.Remove(coin);
            _coinPool.Enqueue(coin);
        }
    }

    public void Update()
    {
        var coinsToRelease = new List<Coin>();

        foreach (var coin in _activeCoins)
        {
            coin.Update();
            if (!coin.IsActive)
            {
                coinsToRelease.Add(coin);
            }
        }

        foreach (var coin in coinsToRelease)
        {
            ReleaseCoin(coin);
        }
    }

    public int AvailableCoinsCount()
    {
        return _coinPool.Count;
    }

    public int ActiveCoinsCount()
    {
        return _activeCoins.Count;
    }
}
