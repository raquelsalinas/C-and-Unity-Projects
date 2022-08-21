using System;


namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddHours(userInput));

            Console.ReadLine();
        }
    }
}
