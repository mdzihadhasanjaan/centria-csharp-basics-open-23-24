namespace Exercise036
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      while(true)
      {
        Console.WriteLine("Give a number:");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput == 0)
        {
          break;
        }
        if (userInput < 0)
        {
          Console.WriteLine("That is negative");

        }
        if (userInput > 0)
        {
          int x;
          x = userInput * userInput;
          Console.WriteLine($"{x}");
        }
      }

    }
  }
}
