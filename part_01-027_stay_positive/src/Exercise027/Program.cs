namespace Exercise027
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      int x = int.Parse(Console.ReadLine());
      if (x > 0)
      {
        Console.WriteLine("It is positive");
      }
      else {
        Console.WriteLine("It is not positive");
      }
    }
  }
}




