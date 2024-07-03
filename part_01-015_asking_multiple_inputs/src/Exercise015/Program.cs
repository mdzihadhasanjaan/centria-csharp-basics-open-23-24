namespace Exercise015
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      string userInput1 = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      int userInput2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Give a double:");
      double userInput3 = double.Parse(Console.ReadLine());
      Console.WriteLine("Give a boolean:");
      bool userInput4 = bool.Parse(Console.ReadLine());
      Console.WriteLine($"Your string: {userInput1}");
      Console.WriteLine($"Your integer: {userInput2}");
      Console.WriteLine($"Your double: {userInput3}");
      Console.WriteLine($"Your boolean: {userInput4}");

    }
  }
}
