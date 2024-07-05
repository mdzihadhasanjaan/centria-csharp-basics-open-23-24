namespace Exercise023
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
      int sum = x + y;
      int sub = x - y;
      int mul = x * y;
      double div = (double)x / y;
      Console.WriteLine($"{x} + {y} = {sum}");
      Console.WriteLine($"{x} - {y} = {sub}");
      Console.WriteLine($"{x} * {y} = {mul}");
      Console.WriteLine($"{x} / {y} = {div}");
    }
  }
}
