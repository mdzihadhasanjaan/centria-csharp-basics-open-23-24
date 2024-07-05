namespace Exercise031
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      int x = int.Parse(Console.ReadLine());
      if (x % 2 == 0)
      {
        Console.WriteLine("It is even.");
      
      }
      else 
    {
      Console.WriteLine("It is odd.");
    }
    }
  }
}
