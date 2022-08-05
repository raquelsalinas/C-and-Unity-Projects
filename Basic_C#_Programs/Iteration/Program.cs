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

        int x = 0;

        while (x <= Languages.Length)
        {
            Console.WriteLine(Languages[x] + userInput);
            x++;
        }
        Console.ReadLine();

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
        Console.ReadLine();

        for (int j = 0; j <= 10; j ++)
        {
            Console.WriteLine(j);
        }
        Console.ReadLine();

        Part4:
        Console.WriteLine("Please write a the name of a big city in the United States:");
        string userCity = Console.ReadLine();

        List<string> cities = new List<string>() { "Chicago", "New York", "Miami", "Boston", "Houston", "Phoenix", "Philadelphia", "San Antonio" };

        foreach (string city in cities)
        {
            if(city == userCity)
            {
                Console.WriteLine("You wrote, " + userCity + ", and that was in my list. Good job!");
                Console.ReadLine();
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Sorry, " + userCity + ", isn't in the list. Try again.");
                goto Part4;
            }
        }
        //Part 5
        List<string> names = new List<string>() { "Annie", "Bob", "Dean", "Dean" };

        Console.WriteLine("Please select a name from these options: Annie, Bob, or Dean");
        string userName = Console.ReadLine();
        
        bool matchIndex = false;

        for (int c = 0; c <= names.Count; c++)
        {
            if (names[c] == userName)
            {
                matchIndex = true;
                Console.WriteLine("That name appeared at the index: " + c + ".");
                Console.ReadLine();
            }

        }
        if (matchIndex == false)
        {
            Console.WriteLine("Sorry, this name isn't in the list.");
            Console.ReadLine();
        }

        //Part 6
        List<string> animals = new List<string>() { "Orca", "Lion", "Tiger", "Tiger" };
        List<string> animals2 = new List<string>();

        Console.WriteLine("This loop will check if my animal list has any duplicates.");

        foreach (string animal in animals)
        {
            if (!animals2.Contains(animal))
            {
                animals2.Add(animal);
            }
            else
            {
                Console.WriteLine(animal + " has already showed up in the list.");
                Console.ReadLine();
            }
        }
    }
}