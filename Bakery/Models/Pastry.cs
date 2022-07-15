using System;

namespace Bakery
{
  public class Pastry
  {
    private static int _Cost = 2;
    public int Amount { get; set; }
    public int TotalCost { get; set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public static int Cost
    {
      get { return _Cost; }
    }

    public bool IsPastry()
    {
     return Amount > 0;
    }

    public void CalcTotalCost()
    {
      for (int i = 1; i <= Amount; i ++)
      {
        TotalCost += Cost;
      }
    }
  }
}