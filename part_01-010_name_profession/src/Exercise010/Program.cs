namespace Exercise010
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("I will tell a story, but I need some information.");
      Console.WriteLine("Give a name for main character:");
      string userInput1 = Console.ReadLine();
      Console.WriteLine("Give the character a profession:");
      string userInput2 = Console.ReadLine();
      Console.WriteLine($"Here is the story:\nOnce upon a time there was a {userInput2} called {userInput1}\nOn her way to work, {userInput1} often pondered what being {userInput2} meant to them.\nWhen you work as a {userInput2} you meet interesting people.\n{userInput1} enjoys their work as {userInput2}, The end.");
    }
  }
}
