namespace ComMgr.Data;

public class Adopt : IAuction
{
    public string Name { get; set; }
    public string Buyer { get; set; }

    public int StartBid { get; set; }

    public int MinRaise { get; set; }

    public int AutoBuy { get; set; }
    public DateTime ExpirationDate { get; set; } = DateTime.Today.AddDays(1);
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set; }
}