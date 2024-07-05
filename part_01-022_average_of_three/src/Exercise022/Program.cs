namespace Exercise022
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
      Console.WriteLine("Give the third number!");
      int z = int.Parse(Console.ReadLine());
      double avr = (x + y + z) / 3.0;
      Console.WriteLine($"The average is {avr}");

    }
  }
}
