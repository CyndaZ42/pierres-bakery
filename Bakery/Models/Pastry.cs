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
        if (i % 3 == 0)
        {
          TotalCost += Cost - 1;
        }
        else 
        {
          TotalCost += Cost;
        }
      }
    }

    public void Print()
    {
      string line1 = "";
      string line2 = "";
      string line3 = "";
      string line4 = "";
      string line5 = "";
      string line6 = "";
      string line7 = "";
      string line8 = "";
      string line9 = "";
      for (int i = 0; i < Amount; i++)
      {
        line1 += @"               /=****=\             ";
        line2 += "           ##**************         ";
        line3 += @"         /=##************##=\       ";
        line4 += "     /=##**####********####****     ";
        line5 += @"     ##******####****####******=\   ";
        line6 += @"   **##****##########@@##****####=\ ";
        line7 += " /=**##########@@####@@##****##**## ";
        line8 += " ******@@##@@##======**##@@##@@##** ";
        line9 += " **####                        @@## ";
      }
      Console.WriteLine(line1);
      Console.WriteLine(line2);
      Console.WriteLine(line3);
      Console.WriteLine(line4);
      Console.WriteLine(line5);
      Console.WriteLine(line6);
      Console.WriteLine(line7);
      Console.WriteLine(line8);
    }
  }
}