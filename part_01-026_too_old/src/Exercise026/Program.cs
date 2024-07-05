namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your year of birth:");
            int x = int.Parse(Console.ReadLine());
            if (x < 1900)
            {
                Console.WriteLine("You're old");
            }
        }
    }
}
