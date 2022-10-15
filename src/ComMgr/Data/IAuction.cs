namespace ComMgr.Data;

public interface IAuction : IOrder
{
    public int StartBid { get; set; }

    public int MinRaise { get; set; }

    public int AutoBuy { get; set; }
}