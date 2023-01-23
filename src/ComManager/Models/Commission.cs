namespace ComManager.Models;

public record Commission : ITransaction
{
  public string Name { get; set; }
  public string Buyer { get; set; }
  public string Currency { get; set; }
  public int Price { get; set; }
  public string Payment { get; set; }
  public string Reference { get; set; }
  public DateTime PurchaseDate { get; set; }
  public string Description { get; set; }
}
