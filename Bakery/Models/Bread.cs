using System;

namespace Bakery
{
  public class Bread
  {
    private static int _Cost = 5; 
    public int Amount { get; set; }
    public int TotalCost { get; set; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public static int Cost
    {
      get { return _Cost; }
    }

    public bool IsBread()
    {
     return Amount > 0;
    }

    public void CalcTotalCost()
    {
      for (int i = 1; i <= Amount; i ++)
      {
        if (i % 3 != 0)
        {
          TotalCost += Cost;
        }
      }
    }


  }
}