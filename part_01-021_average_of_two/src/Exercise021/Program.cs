namespace Exercise021
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
      float avr = float.Parse((x + y) / 2);
      Console.WriteLine($"The average is {avr}");
    }
  }
}
