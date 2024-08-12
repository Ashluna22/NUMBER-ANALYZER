using System;


namespace Number_analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 100");
            int leNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + leNumber);

            if (leNumber % 2 == 0)
            {
                if (leNumber < 60)
                {
                    Console.WriteLine(leNumber + " is an even number and less than 60");
                }
                else if (leNumber > 60)
                {
                    Console.WriteLine(leNumber + " is an even number and greater than 60");
                }

                if (leNumber >= 2 && leNumber <= 24)
                {
                    Console.WriteLine(leNumber + " is an even number and less than 25");
                }
                else if (leNumber >= 26 && leNumber <= 60)
                {
                    Console.WriteLine(leNumber + " is even and between 26 and 60 inclusive");
                }
            }
            else
            {
                if (leNumber < 60)
                {
                    Console.WriteLine(leNumber + " is an odd number and less than 60");
                }
                else
                {
                    Console.WriteLine(leNumber + " is an odd number and greater than 60");
                }
            }
        }
    }
}
