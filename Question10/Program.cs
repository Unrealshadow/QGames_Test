class Program
{
    static void Main(string[] args)
    {
        CoinObjectPool pool = new CoinObjectPool();

        Console.WriteLine($"Initial Coins in Pool: {pool.AvailableCoinsCount()}");

        // Simulate getting and using coins
        Coin coin1 = pool.GetCoin();
        Coin coin2 = pool.GetCoin();

        Console.WriteLine($"Coins in Pool after getting two coins: {pool.AvailableCoinsCount()}");

        // Simulate updating coins for less than 300 frames
        for (int i = 0; i < 250; i++)
        {
            coin1.Update();
            coin2.Update();
        }

        // Check states before they become inactive
        Console.WriteLine($"After 250 frames: Coin1 Active: {coin1.IsActive}, Coin2 Active: {coin2.IsActive}");

        // Complete 300 frame updates
        for (int i = 250; i < 300; i++)
        {
            coin1.Update();
            coin2.Update();
        }

        // Check states at 300 frames
        Console.WriteLine($"After 300 frames: Coin1 Active: {coin1.IsActive}, Coin2 Active: {coin2.IsActive}");

        // Simulate player collecting one coin
        coin1.Collect();

        // Update the pool
        pool.Update();

        // Check states after pool update
        Console.WriteLine($"After pool update: Coin1 Active: {coin1.IsActive}, Coin2 Active: {coin2.IsActive}");
        Console.WriteLine($"Active Coins: {pool.ActiveCoinsCount()}");
        Console.WriteLine($"Coins in Pool after updates: {pool.AvailableCoinsCount()}");
    }
}
