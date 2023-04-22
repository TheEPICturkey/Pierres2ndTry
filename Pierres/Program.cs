using System;
// using System.Collections.Generic;
// using System.Linq;

namespace Bakery
{
    public class Program
    {
      public static void Main(){
        Console.Clear();
        StartMenu();

      }

      private static void StartMenu(){
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|    Welcome to Pierre's Bakery    |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread...........................$5|");
        Console.WriteLine("|Pastry..........................$2|");
        Console.WriteLine("|                                  |");
        Console.WriteLine("|Bread: 3 for 2$   Pastry: 4 for 3$|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("Press any key to continue, esc to leave...");
        if(Console.ReadKey().Key == ConsoleKey.Escape)
        {
          Console.Clear();
          Console.WriteLine("Hope to see you soon!");
        } 
        else 
        {
          BuyBread();
        }
      }
      private static void BuyBread()
      {
        Console.Clear();
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread...........................$5|");
        Console.WriteLine("|                                  |");
        Console.WriteLine("|Bread: Buy 2, Get One Free        |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("How many loaves of bread you would like to buy?");
        int breadToBuy;
        bool success = int.TryParse(Console.ReadLine(), out breadToBuy);
        if (success)
        {
          BuyPastry(breadToBuy);
        } 
        else 
        {
          Console.WriteLine("Invalid Selection, please try again.");
          BuyBread();
        }
      }
      private static void BuyPastry(int breadToBuy)
      {
        Console.Clear();
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Pastry..........................$2|");
        Console.WriteLine("|                                  |");
        Console.WriteLine("|     Pastry: Buy 3, Get 1 Free    |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("How many pastries you would like to buy?");
        int pastryToBuy;
        bool success = int.TryParse(Console.ReadLine(), out pastryToBuy);
        if (success)
        {
          int[] checkOut = {breadToBuy, pastryToBuy};
          CheckOut(checkOut);
        } 
        else 
        {
          Console.WriteLine("Invalid Selection, please try again.");
          BuyPastry(breadToBuy);
        }
      }

      private static void CheckOut(int[] checkOut)
      {
        Bread buyBread = new Bread(checkOut[0]);
        Pastry buyPastry = new Pastry(checkOut[1]);
        buyBread.CalcCost();
        buyPastry.CalcCost();
        int total = buyBread.TotalCost + buyPastry.TotalCost;

        int breadLength = 23 - buyBread.TotalCost.ToString().Length;
        int pastryLength = 22 - buyPastry.TotalCost.ToString().Length;
        int totalLength = 25 - total.ToString().Length;

        string breadLine = "";
        string pastryLine = "";
        string totalLine = "";

        for(int i = 0; i < breadLength - checkOut[0].ToString().Length; i++){ breadLine += ".";}
        for(int i = 0; i < pastryLength - checkOut[1].ToString().Length; i++){ pastryLine += ".";}
        for(int i = 0; i< totalLength; i++){ totalLine += ".";}

        Console.Clear();
        
        Console.WriteLine("*----------------------------------*");//34
        Console.WriteLine("|             Reciept              |");
        Console.WriteLine("|          Pierres Bakery          |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread x" + checkOut[0]  + breadLine + "$"+ buyBread.TotalCost.ToString() +".00|");
        Console.WriteLine("|Pastry x" + checkOut[1] +  pastryLine + "$"+ buyPastry.TotalCost.ToString() +".00|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Total" + totalLine + "$"+ total.ToString() +".00|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("Press any key to exit...");
        if(Console.ReadKey().Key == ConsoleKey.M )
        {
          EasterEgg();
        }
        else
        {
          Console.Clear();
          Console.WriteLine("You leave with your bread.");
        }
      }

      private static void EasterEgg()
      {
        Console.Clear();
        Console.WriteLine("If you get here, you are doing great in life. Keep your head up! Here is 1 free bread and pastery by the way!");
      }
    }
}