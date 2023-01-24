namespace ComManager.Models;

public record YourCharacterHere : IAuction
{
  public string Name { get; set; }
  public string Buyer { get; set; }
  public int StartBid { get; set; }

  public int MinRaise { get; set; }

  public int AutoBuy { get; set; }
  public DateTime PurchaseDate { get; set; }
  public int Slot { get; set; } = 1;
  public int Price { get; set; }
}