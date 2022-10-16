using ComMgr.Data;

namespace ComMgr.Services;

public class TransactionService
{
    static readonly string[] Types = new[]
    {
        "YCH", "Adopt", "Commission"
    };

    static readonly string[] Buyers = new[]
    {
        "Tom Wilcox", "Zack Casey", "Aidan Cheddar", "Kit Welsh", "Zenon Tigerpaw"
    };

    public Task<Transaction[]> GetTransactionsAsync()
    {
        return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Transaction
        {
            PurchaseDate = DateTime.Now.AddDays(Random.Shared.Next(10, 30)),
            Price = Random.Shared.Next(2, 200),
            Buyer = Buyers[Random.Shared.Next(Buyers.Length)],
            Type = Types[Random.Shared.Next(Types.Length)],
            Description = $"{Types[Random.Shared.Next(Types.Length)]} for {Buyers[Random.Shared.Next(Buyers.Length)]}"
        }).ToArray());
    }
}
