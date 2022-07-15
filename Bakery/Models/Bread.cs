using System;

namespace Bakery
{
  public class Bread
  {
    public int Amount { get; set; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public bool IsBread()
    {
     return Amount > 0;
    }
  }
}