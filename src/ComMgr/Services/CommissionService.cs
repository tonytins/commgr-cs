using ComMgr.Data;

namespace ComMgr.Services;

public class CommissionService
{
    private static readonly string[] Descriptions = new[]
    {
        "YCH", "Adopt", "Commission"
    };

    static readonly string[] Buyers = new[]
    {
        "Tom Wilcox", "Zack Casey", "Aidan Cheddar", "Kit Welsh", "Zenon Tigerpaw"
    };

    public Task<Commission[]> GetOrdersAsync()
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Commission
        {
            PurchaseDate = DateTime.Now.AddDays(Random.Shared.Next(10, 30)),
            Price = Random.Shared.Next(2, 200),
            Buyer = Buyers[Random.Shared.Next(Buyers.Length)],
            Description = Descriptions[Random.Shared.Next(Descriptions.Length)]
        }).ToArray());
    }
}
