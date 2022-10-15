namespace ComMgr.Data;

public interface IAuction : ITransaction
{
    public int StartBid { get; set; }

    public int MinRaise { get; set; }

    public int AutoBuy { get; set; }
}