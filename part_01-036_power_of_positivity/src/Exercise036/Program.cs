namespace Exercise036
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int number;

        Console.WriteLine("Give a number (0 to stop):");
        number = Convert.ToInt32(Console.ReadLine());

        while (number != 0)
        {
            if (number > 0)
            {
                Console.WriteLine(number * number);
            }
            else if (number < 0)
            {
                Console.WriteLine("That is negative");
            }

            Console.WriteLine("Give a number (0 to stop):");
            number = Convert.ToInt32(Console.ReadLine());
        }
    
    }
  }
}
