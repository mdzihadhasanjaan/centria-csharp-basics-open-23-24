﻿namespace Exercise013
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      double userInput = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine($"You gave {userInput}");
    }
  }
}
