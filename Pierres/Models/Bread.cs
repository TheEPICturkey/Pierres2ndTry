namespace Bakery
{
  public class Bread
  {
    public int ToBuy { get; set; }
    private int _cost;
    public int TotalCost {get; set;}
    public Bread(int toBuy)
    {
      ToBuy = toBuy;
      _cost = 5;
      TotalCost = 0;
    }
    public void CalcCost() 
    {
      int hasDiscount = ToBuy / 3;
      for(int i = hasDiscount; i < ToBuy; i++)
      {
        TotalCost += _cost;
      }

    }
  }
}