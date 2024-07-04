namespace Exercise020
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
      int mul = x * y;
      Console.WriteLine($"{x} * {y} = {mul}");
    }
  }
}
