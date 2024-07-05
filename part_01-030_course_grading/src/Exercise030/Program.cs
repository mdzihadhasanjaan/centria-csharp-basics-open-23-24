namespace Exercise030
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine($"Give your percent [0 - 100]:");

      int num = int.Parse(Console.ReadLine());

      if ( num < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (num <= 49)
      {
        Console.WriteLine("Fail");
      }
      else if(num <= 59)
      {
        Console.WriteLine("Grade: 1");
      
      }
      else if (num <= 69)
      {
        Console.WriteLine("Grade: 2");

      }
      else if (num <= 79)
      {
        Console.WriteLine("Grade: 3");
      }

      else if (num <= 89)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (num <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      if (num > 100)
      {
        Console.WriteLine("Outstanding!");
      }

      
    }
  }
}
