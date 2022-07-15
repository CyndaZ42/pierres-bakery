using System;
using System.Threading;

namespace Bakery {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("#───────────────────#");
      Console.WriteLine("|  Pierre's Bakery  |");
      Console.WriteLine("#───────────────────#");
      char[] welcome = { 'W','e','l','c','o','m','e',' ','t','o',' ','P','i','e','r','r','e','s',' ','B','a','k','e','r','y','!'};
      foreach (char letter in welcome)
      {
        Console.Write(letter);
        Thread.Sleep(70);
      }
    }
  }
}