using System;
using System.Threading;

namespace Bakery {
  public class Program
  {
    public static void Main()
    {
      string yes = "yesokaysureyep";
      Console.Clear();
      Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 12) + "}", "+──────────────────────+"));
      Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 12) + "}", "|   Pierre's  Bakery   |"));
      Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + 12) + "}", "+──────────────────────+"));
      SpeakNSpell("Welcome to Pierre's bakery!");
      SpeakNSpell("Would you like to hear today's deals?");
      string introMenu = Console.ReadLine();
      if (yes.Contains(introMenu.ToLower()))
      {
        SpeakNSpell("Here are today's deals."); 
        SpeakNSpell("Our bread is buy 2 get 1 free,");
        SpeakNSpell("and we have $1 off pastries for every 3 that you buy.");
        SpeakNSpell("What would you like today?");
      }
      else
      {
        SpeakNSpell("Oh... Okay. What would you like to buy?");
      }
      MainMenu();
    }

    public static void MainMenu()
    {
      string loaf = "loafbreads";
      string pie = "pastrysdoughnutsbear clawbeignetdanish";
      string deals = "dealsalecoupon";
      string confused = "menuoptionsinventoryprice";
      string exit = "byexitleavesc";
      string menuInput = Console.ReadLine();
      if (loaf.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("How many loaves would you like?");
        int breadAmount;
        for (int j = 0; j < 1; j = j)
        {
          string breadInput = Console.ReadLine();
          if (int.TryParse(breadInput, out breadAmount))
          {
            Bread moarBread = new Bread(breadAmount);
            moarBread.CalcTotalCost();
            SpeakNSpell("Your total comes to $" + moarBread.TotalCost);
            moarBread.Print();
            j = 1;
          }
          else
          {
            SpeakNSpell("I'm a trifle deaf in this ear. Speak a little louder next time.");
          }
        }
        SpeakNSpell("Thankyou for shopping at Pierre's Bakery");
      }
      else if (pie.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("How many pastries would you like?");
        int pastryAmount;
        for (int j = 0; j < 1; j = j)
        {
          string pastryInput = Console.ReadLine();
          if (int.TryParse(pastryInput, out pastryAmount))
          {
            Pastry moarPastry = new Pastry(pastryAmount);
            moarPastry.CalcTotalCost();
            SpeakNSpell("Your total comes to $" + moarPastry.TotalCost);
            moarPastry.Print();
            j = 1;
          }
          else
          {
            SpeakNSpell("I'm a trifle deaf in this ear. Speak a little louder next time.");
          }
        }
        SpeakNSpell("Thankyou for shopping at Pierre's Bakery");
      }
      else if (deals.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("Here are today's deals."); 
        SpeakNSpell("Our bread is buy 2 get 1 free,");
        SpeakNSpell("and we have $1 off pastries for every 3 that you buy.");
        MainMenu();
      }
      else if (confused.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("Today we have freshly baked bread and pastries available.");
        SpeakNSpell("One loaf of bread is $" + Bread.Cost);
        SpeakNSpell("and all of our pastries are $" + Pastry.Cost);
        MainMenu();
      }
      else if (exit.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("See you again soon.");
      }
      else
      {
        SpeakNSpell("I'm a trifle deaf in this ear. Speak a little louder next time.");
        MainMenu();
      }
    }

    public static void SpeakNSpell(string word)
    {
      char[] wordArray = new char[word.Length];
      for (int i = 0; i < word.Length; i++)
      {
        wordArray[i] = word[i];
      }
      foreach (char letter in wordArray)
      {
        Console.Write(letter);
        Thread.Sleep(70);
      }
      Thread.Sleep(100);
      Console.WriteLine("");
    }
  }
}