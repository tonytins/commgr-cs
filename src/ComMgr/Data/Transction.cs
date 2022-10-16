namespace ComMgr.Data;

public class Transaction : ITransaction
{
    public string Name { get; set; }
    public string Buyer { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
}