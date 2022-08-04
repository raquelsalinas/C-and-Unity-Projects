using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        Console.WriteLine("Please input some text: ");
        string userInput = Console.ReadLine();

        string[] Languages = new string[4];
        Languages[0] = "C#";
        Languages[1] = "Java";
        Languages[2] = "C++";
        Languages[3] = "HTML";

        for (int x = 0; x <= 4; x++)
        {
            Console.Write(Languages[x] + userInput);
        }

        //Part 2
        while (true)
        {
            Console.WriteLine("Hello, World!");
        }

        //Part 3
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        for (int j = 0; j <= 10; j = j + 1)
        {
            Console.WriteLine(j);
        }

        //Part 4
        Console.WriteLine("Please write a the name of a big city in the United States.");
        string userCity = Console.ReadLine();

        List<string> cities = new List<string>() { "Chicago", "New York", "Miami", "Boston" };

        foreach (string city in cities)
        {
            if(city == userCity)
            {
                Console.WriteLine(city);
                Console.ReadLine();
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Sorry, this city isn't in the list. Try again.");
                return;
            }
        }
    }
}