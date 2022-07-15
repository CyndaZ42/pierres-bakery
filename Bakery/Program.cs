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
        SpeakNSpell("Oh... Okay. What would you like to buy");
      }
      MainMenu();
    }

    public static void MainMenu()
    {
      string loaf = "loafbreads";
      string pie = "pastrysdoughnutsbear clawbeignetdanish";
      string forSale = "menuoptionsinventory";
      string exit = "byexitleavesc";
      string menuInput = Console.ReadLine();
      if (loaf.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("How many loaves would you like?");
        string breadInput = Console.ReadLine();
      }
      else if (pie.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("How many pastries would you like?");
        string pastryInput = Console.ReadLine();
      }
      else if (forSale.Contains(menuInput.ToLower()))
      {
        SpeakNSpell("Today we have ");
        string choiche = Console.ReadLine();
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