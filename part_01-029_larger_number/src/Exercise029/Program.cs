namespace Exercise029
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      int x = int.Parse(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int y = int.Parse(Console.ReadLine());
      if ( x > y)
      {
        Console.WriteLine($"The larger number is {x}!");
      }
      else if (x < y)
      {
        Console.WriteLine($"The larger number is {y}!");
      }
      else 
      {
        Console.WriteLine("They are equal!");
      }
    }
  }
}
