namespace ComMgr.Data;

public interface IOrder
{
    public string Name { get; set; }
    public string Buyer { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set; }
}
