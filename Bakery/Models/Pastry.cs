using System;

namespace Bakery
{
  public class Pastry
  {
    private static int _Cost = 2;
    public int Amount { get; set; }

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
  }
}