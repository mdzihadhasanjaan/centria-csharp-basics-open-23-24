namespace Exercise035
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      while (true)
    {
      Console.WriteLine("Give a number:");
      int userInput = int.Parse(Console.ReadLine());
      if (userInput == 42)
      {
        break;
      }
    }
    }
  }
}
